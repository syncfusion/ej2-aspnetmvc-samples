#region Copyright Syncfusion Inc. 2001-2022.
// Copyright Syncfusion Inc. 2001-2022. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Syncfusion.Pdf;
using Syncfusion.XPS;
using Syncfusion.Mvc.Pdf;
using System.IO;
using EJ2MVCSampleBrowser.Models;
using System.Text;
using Syncfusion.Pdf.Parsing;
using System.Security.Cryptography.X509Certificates;
using Syncfusion.Pdf.Security;

namespace EJ2MVCSampleBrowser.Controllers.PDF
{
    public partial class PdfController : Controller
    {
        //
        // GET: /FindPDFCorruption/

        public ActionResult DigitalSignatureValidation()
        {
            SignatureValidationMesssage message = new SignatureValidationMesssage();
            message.Message = string.Empty;
            return View("DigitalSignatureValidation", message);
        }
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult DigitalSignatureValidation(string InsideBrowser)
        {

            SignatureValidationMesssage message = new SignatureValidationMesssage();


            FileStream fileStreamInput = new FileStream(ResolveApplicationDataPath("DigitalSignature.pdf"), FileMode.Open, FileAccess.Read);

            //Load an existing signed PDF document
            PdfLoadedDocument ldoc = new PdfLoadedDocument(fileStreamInput);

            //Get signature field.
            PdfLoadedSignatureField lSigFld = ldoc.Form.Fields[0] as PdfLoadedSignatureField;

            //X509Certificate2Collection to check the signer's identity using root certificates.
            X509CertificateCollection collection = new X509CertificateCollection();

            //Read the certificate file.
            FileStream pfxFile = new FileStream(ResolveApplicationDataPath(@"PDF.pfx"), FileMode.Open, FileAccess.Read, FileShare.ReadWrite);

            byte[] data = new byte[pfxFile.Length];

            pfxFile.Read(data, 0, data.Length);

            //Create new X509Certificate2 with the root certificate.
            X509Certificate2 certificate = new X509Certificate2(data, "password123");

            //Add the certificate to the collection.
            collection.Add(certificate);

            //Validate signature and get the validation result
            PdfSignatureValidationResult result = lSigFld.ValidateSignature(collection);

            StringBuilder builder = new StringBuilder();

            builder.AppendLine("Signature is " + result.SignatureStatus);

            builder.AppendLine();
            builder.AppendLine("--------Validation Summary--------");
            builder.AppendLine();

            //Checks whether the document is modified or not
            bool isModified = result.IsDocumentModified;
            if (isModified)
                builder.AppendLine("The document has been altered or corrupted since the signature was applied.");
            else
                builder.AppendLine("The document has not been modified since the signature was applied.");

            //Signature details
            builder.AppendLine("Digitally signed by " + lSigFld.Signature.Certificate.IssuerName);
            builder.AppendLine("Valid From : " + lSigFld.Signature.Certificate.ValidFrom);
            builder.AppendLine("Valid To : " + lSigFld.Signature.Certificate.ValidTo);
            builder.AppendLine("Signature Algorithm : " + result.SignatureAlgorithm);
            builder.AppendLine("Hash Algorithm : " + result.DigestAlgorithm);

            //Revocation validation details
            builder.AppendLine("OCSP revocation status : " + result.RevocationResult.OcspRevocationStatus);
            if (result.RevocationResult.OcspRevocationStatus == RevocationStatus.None && result.RevocationResult.IsRevokedCRL)
                builder.AppendLine("CRL is revoked.");

            //Close the document
            ldoc.Close(true);

            message.Message = builder.ToString();
            return View("DigitalSignatureValidation", message);

        }
    }
}
