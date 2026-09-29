using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace EJ2CoreSampleBrowser.Models
{
    public class FormRendererData
    {
        public Schema GetData()
        {
            Schema formSchema = new Schema
            {
                Version = "0.1.0",
                Properties = new SchemaProperties
                {
                    Html = new HtmlProperty
                    {
                        Id = "staticHtml_1779366656553_385",
                        Name = "staticHtml_553",
                        Type = "string",
                        Label = "HTML",
                        DefaultValue = "<div class=\"form-title\"><h1>Registration Form</h1></div><hr>",
                        Widget = "staticHtml",
                        Size = "Bigger"
                    },
                    LastName = new TextboxProperty
                    {
                        Id = "textbox_1778743492061_220",
                        Name = "textbox_267",
                        Type = "string",
                        Label = "Last Name",
                        TextboxType = "text",
                        Required = true,
                        Widget = "textbox",
                        LabelPosition = "top",
                        Autocomplete = true,
                        Size = "Bigger"
                    },
                    FirstName = new TextboxProperty
                    {
                        Id = "textbox_1778743347128_521",
                        Name = "textbox_624",
                        Type = "string",
                        Label = "First Name",
                        TextboxType = "text",
                        Required = true,
                        Widget = "textbox",
                        LabelPosition = "top",
                        Autocomplete = true,
                        Size = "Bigger"
                    },
                    PhoneNumber = new TextboxProperty
                    {
                        Id = "textbox_1778743694408_294",
                        Name = "textbox_604",
                        Type = "string",
                        Label = "Phone Number",
                        TextboxType = "number",
                        Widget = "inputMask",
                        LabelPosition = "top",
                        Autocomplete = true,
                        Size = "Bigger"
                    },
                    UserName = new TextboxProperty
                    {
                        Id = "textbox_1778743622010_848",
                        Name = "textbox_684",
                        Type = "string",
                        Label = "User Name",
                        TextboxType = "text",
                        Required = true,
                        Widget = "textbox",
                        LabelPosition = "top",
                        Autocomplete = true,
                        Size = "Bigger"
                    },
                    ConfirmPassword = new ConfirmPasswordProperty
                    {
                        Id = "textbox_1778744420029_685",
                        Name = "textbox_29",
                        Type = "string",
                        Label = "Confirm Password",
                        TextboxType = "password",
                        Required = true,
                        Widget = "textbox",
                        LabelPosition = "top",
                        Size = "Bigger",
                        CustomValidation = new List<CustomValidationRule>
                            {
                                new CustomValidationRule
                                {
                                    Expression = "valid = (input === {textbox_715}) ? true : 'Confirm password should match password'"
                                }
                            }
                    },
                    Password = new PasswordProperty
                    {
                        Id = "textbox_1778744397712_334",
                        Name = "textbox_715",
                        Type = "string",
                        Label = "Password",
                        TextboxType = "password",
                        Required = true,
                        MinLength = 8,
                        Widget = "textbox",
                        LabelPosition = "top",
                        Size = "Bigger"
                    },
                    IAgreeToTheTermsAndConditions = new CheckboxProperty
                    {
                        Id = "checkbox_1779362732753_574",
                        Name = "checkbox_867",
                        Type = "boolean",
                        Label = "I agree to the Terms and Conditions",
                        Widget = "checkbox",
                        Size = "Bigger"
                    },
                    Submit = new SubmitButtonProperty
                    {
                        Id = "submit_button_initial",
                        Name = "",
                        Type = "button",
                        Label = "Submit",
                        ButtonType = "submit",
                        Widget = "button",
                        Size = "Bigger"
                    }
                },
                Layout = new List<LayoutNode>
                    {
                        new LayoutNode { Type = "field", PropertyId = "html" },
                        new LayoutNode
                        {
                            Type = "panel",
                            Id = "panel_1779362566261_783",
                            Name = "panel_384",
                            Label = "Personal Information",
                            Children = new List<LayoutNode>
                            {
                                new LayoutNode
                                {
                                    Type = "table",
                                    Id = "table_1779362611831_406",
                                    Name = "table_727",
                                    Label = "Table",
                                    HideBorders = true,
                                    Rows = 1,
                                    Cols = 2,
                                    Cells = new List<List<TableCell>>
                                    {
                                        new List<TableCell>
                                        {
                                            new TableCell
                                            {
                                                Row = 0,
                                                Col = 0,
                                                Children = new List<LayoutNode>
                                                {
                                                    new LayoutNode { Type = "field", PropertyId = "firstName" }
                                                }
                                            },
                                            new TableCell
                                            {
                                                Row = 0,
                                                Col = 1,
                                                Children = new List<LayoutNode>
                                                {
                                                    new LayoutNode { Type = "field", PropertyId = "lastName" }
                                                }
                                            }
                                        }
                                    }
                                },
                                new LayoutNode { Type = "field", PropertyId = "phoneNumber" }
                            }
                        },
                        new LayoutNode
                        {
                            Type = "panel",
                            Id = "panel_1779362669605_403",
                            Name = "panel_554",
                            Label = "Account Details",
                            Children = new List<LayoutNode>
                            {
                                new LayoutNode { Type = "field", PropertyId = "userName" },
                                new LayoutNode
                                {
                                    Type = "table",
                                    Id = "table_1779362720807_367",
                                    Name = "table_728",
                                    Label = "Table",
                                    HideBorders = true,
                                    Rows = 1,
                                    Cols = 2,
                                    Cells = new List<List<TableCell>>
                                    {
                                        new List<TableCell>
                                        {
                                            new TableCell
                                            {
                                                Row = 0,
                                                Col = 0,
                                                Children = new List<LayoutNode>
                                                {
                                                    new LayoutNode { Type = "field", PropertyId = "password" }
                                                }
                                            },
                                            new TableCell
                                            {
                                                Row = 0,
                                                Col = 1,
                                                Children = new List<LayoutNode>
                                                {
                                                    new LayoutNode { Type = "field", PropertyId = "confirmPassword" }
                                                }
                                            }
                                        }
                                    }
                                },
                                new LayoutNode { Type = "field", PropertyId = "iAgreeToTheTermsAndConditions" }
                            }
                        },
                        new LayoutNode { Type = "field", PropertyId = "submit" }
                    },
                Settings = new SchemaSettings
                {
                    Name = "Registration Form",
                    Width = "700px"
                }
            };

            return formSchema;
        }


        public Schema GetContactForm()
        {
            return new Schema
            {
                Version = "1.0.0",
                Properties = new SchemaProperties
                {
                    FormHeading = new HtmlProperty
                    {
                        Id = "formHeading",
                        Name = "formHeading",
                        Widget = "staticHtml",
                        HideLabel = true,
                        DefaultValue = "<div style='text-align:center;padding:12px 0;'><h2>Contact Us</h2><p>We would love to hear from you. Please fill out the form below and our team will get back to you.</p></div>"
                    },
                    FullName = new TextboxProperty
                    {
                        Id = "fullName",
                        Name = "fullName",
                        Type = "string",
                        Widget = "textbox",
                        Label = "Full Name",
                        Placeholder = "Enter your fullname",
                        Required = true,
                        MinLength = 2,
                        MaxLength = 100,
                        LabelPosition = "top",
                        TemplateId = "textboxTemplate"
                    },
                    Email = new TextboxProperty
                    {
                        Id = "email",
                        Name = "email",
                        Type = "string",
                        Widget = "textbox",
                        Label = "Email Address",
                        Placeholder = "Enter your email address",
                        TextboxType = "email",
                        Required = true,
                        LabelPosition = "top",
                        TemplateId = "emailTemplate"
                    },
                    InquiryType = new DropdownProperty
                    {
                        Id = "inquiryType",
                        Name = "inquiryType",
                        Type = "string",
                        Widget = "dropdown",
                        Label = "Inquiry Type",
                        DefaultValue = "",
                        Placeholder = "Select inquiry type",
                        LabelPosition = "top",
                        Options = new List<SelectOption>
                        {
                            new SelectOption { Text = "General Inquiry", Value = "general" },
                            new SelectOption { Text = "Sales", Value = "sales" },
                            new SelectOption { Text = "Support", Value = "support" },
                            new SelectOption { Text = "Partnership", Value = "partnership" },
                            new SelectOption { Text = "Feedback", Value = "feedback" }
                        }
                    },
                    Message = new TextareaProperty
                    {
                        Id = "message",
                        Name = "message",
                        Type = "string",
                        Widget = "textarea",
                        Label = "Message",
                        Placeholder = "Enter your message",
                        Required = true,
                        Rows = 5,
                        MinLength = 10,
                        MaxLength = 1000,
                        LabelPosition = "top"
                    },
                    Consent = new CheckboxProperty
                    {
                        Id = "consent",
                        Name = "consent",
                        Type = "boolean",
                        Widget = "checkbox",
                        Label = "I agree to be contacted regarding my inquiry.",
                        Required = true,
                        Checked = false
                    },
                    Submit = new SubmitButtonProperty
                    {
                        Id = "submit",
                        Name = "submit",
                        Type = "button",
                        Label = "Submit",
                        ButtonType = "submit",
                        Widget = "button",
                        Style = "primary"
                    }
                },
                Layout = new List<LayoutNode>
                {
                    new LayoutNode { Type = "field", PropertyId = "formHeading" },
                    new LayoutNode { Type = "field", PropertyId = "fullName" },
                    new LayoutNode { Type = "field", PropertyId = "email" },
                    new LayoutNode { Type = "field", PropertyId = "inquiryType" },
                    new LayoutNode { Type = "field", PropertyId = "message" },
                    new LayoutNode { Type = "field", PropertyId = "consent" },
                    new LayoutNode { Type = "field", PropertyId = "submit" }
                },
                Settings = new SchemaSettings
                {
                    Name = "Contact Us"
                }
            };
        }

        public class Schema
        {
            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("properties")]
            public SchemaProperties Properties { get; set; }

            [JsonProperty("layout")]
            public List<LayoutNode> Layout { get; set; }

            [JsonProperty("settings")]
            public SchemaSettings Settings { get; set; }
        }

        public class SchemaProperties
        {
            [JsonProperty("html")]
            public HtmlProperty Html { get; set; }

            [JsonProperty("lastName")]
            public TextboxProperty LastName { get; set; }

            [JsonProperty("firstName")]
            public TextboxProperty FirstName { get; set; }

            [JsonProperty("phoneNumber")]
            public TextboxProperty PhoneNumber { get; set; }

            [JsonProperty("userName")]
            public TextboxProperty UserName { get; set; }

            [JsonProperty("confirmPassword")]
            public ConfirmPasswordProperty ConfirmPassword { get; set; }

            [JsonProperty("password")]
            public PasswordProperty Password { get; set; }

            [JsonProperty("iAgreeToTheTermsAndConditions")]
            public CheckboxProperty IAgreeToTheTermsAndConditions { get; set; }

            [JsonProperty("submit")]
            public SubmitButtonProperty Submit { get; set; }

            [JsonProperty("formHeading")]
            public HtmlProperty FormHeading { get; set; }

            [JsonProperty("fullName")]
            public TextboxProperty FullName { get; set; }

            [JsonProperty("email")]
            public TextboxProperty Email { get; set; }

            [JsonProperty("inquiryType")]
            public DropdownProperty InquiryType { get; set; }

            [JsonProperty("message")]
            public TextareaProperty Message { get; set; }

            [JsonProperty("consent")]
            public CheckboxProperty Consent { get; set; }
        }

        public class SchemaSettings
        {
            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("width")]
            public string Width { get; set; }
        }

        public class HtmlProperty
        {
            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("type")]
            public string Type { get; set; }

            [JsonProperty("label")]
            public string Label { get; set; }

            [JsonProperty("defaultValue")]
            public string DefaultValue { get; set; }

            [JsonProperty("widget")]
            public string Widget { get; set; }

            [JsonProperty("size")]
            public string Size { get; set; }

            [JsonProperty("hideLabel")]
            public bool HideLabel { get; set; }

            [JsonProperty("placeholder")]
            public string Placeholder { get; set; }
        }

        public class TextboxProperty
        {
            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("type")]
            public string Type { get; set; }

            [JsonProperty("label")]
            public string Label { get; set; }

            [JsonProperty("textboxType")]
            public string TextboxType { get; set; }

            [JsonProperty("required")]
            public bool Required { get; set; }

            [JsonProperty("widget")]
            public string Widget { get; set; }

            [JsonProperty("labelPosition")]
            public string LabelPosition { get; set; }

            [JsonProperty("autocomplete")]
            public bool Autocomplete { get; set; }

            [JsonProperty("size")]
            public string Size { get; set; }

            [JsonProperty("placeholder")]
            public string Placeholder { get; set; }

            [JsonProperty("minLength")]
            public int? MinLength { get; set; }

            [JsonProperty("maxLength")]
            public int? MaxLength { get; set; }

            [JsonProperty("templateId")]
            public string TemplateId { get; set; }

            [JsonProperty("defaultValue")]
            public string DefaultValue { get; set; }

            [JsonProperty("rows")]
            public int? Rows { get; set; }
        }

        public class DropdownProperty : TextboxProperty
        {
            [JsonProperty("options")]
            public List<SelectOption> Options { get; set; }
        }

        public class TextareaProperty : TextboxProperty
        {
            [JsonProperty("rows")]
            public new int Rows { get; set; }
        }

        public class SelectOption
        {
            [JsonProperty("text")]
            public string Text { get; set; }

            [JsonProperty("value")]
            public string Value { get; set; }
        }

        public class ConfirmPasswordProperty
        {
            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("type")]
            public string Type { get; set; }

            [JsonProperty("label")]
            public string Label { get; set; }

            [JsonProperty("textboxType")]
            public string TextboxType { get; set; }

            [JsonProperty("required")]
            public bool Required { get; set; }

            [JsonProperty("widget")]
            public string Widget { get; set; }

            [JsonProperty("labelPosition")]
            public string LabelPosition { get; set; }

            [JsonProperty("size")]
            public string Size { get; set; }

            [JsonProperty("customValidation")]
            public List<CustomValidationRule> CustomValidation { get; set; }
        }

        public class PasswordProperty
        {
            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("type")]
            public string Type { get; set; }

            [JsonProperty("label")]
            public string Label { get; set; }

            [JsonProperty("textboxType")]
            public string TextboxType { get; set; }

            [JsonProperty("required")]
            public bool Required { get; set; }

            [JsonProperty("minLength")]
            public int MinLength { get; set; }

            [JsonProperty("widget")]
            public string Widget { get; set; }

            [JsonProperty("labelPosition")]
            public string LabelPosition { get; set; }

            [JsonProperty("size")]
            public string Size { get; set; }
        }

        public class CheckboxProperty
        {
            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("type")]
            public string Type { get; set; }

            [JsonProperty("label")]
            public string Label { get; set; }

            [JsonProperty("widget")]
            public string Widget { get; set; }

            [JsonProperty("size")]
            public string Size { get; set; }

            [JsonProperty("required")]
            public bool Required { get; set; }

            [JsonProperty("checked")]
            public bool Checked { get; set; }
        }

        public class SubmitButtonProperty
        {
            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("type")]
            public string Type { get; set; }

            [JsonProperty("label")]
            public string Label { get; set; }

            [JsonProperty("buttonType")]
            public string ButtonType { get; set; }

            [JsonProperty("widget")]
            public string Widget { get; set; }

            [JsonProperty("size")]
            public string Size { get; set; }

            [JsonProperty("style")]
            public string Style { get; set; }
        }

        public class CustomValidationRule
        {
            [JsonProperty("expression")]
            public string Expression { get; set; }
        }

        public class LayoutNode
        {
            [JsonProperty("type")]
            public string Type { get; set; }

            [JsonProperty("propertyId")]
            public string PropertyId { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("label")]
            public string Label { get; set; }

            [JsonProperty("hideBorders")]
            public bool HideBorders { get; set; }

            [JsonProperty("rows")]
            public int Rows { get; set; }

            [JsonProperty("cols")]
            public int Cols { get; set; }

            [JsonProperty("cells")]
            public List<List<TableCell>> Cells { get; set; }

            [JsonProperty("children")]
            public List<LayoutNode> Children { get; set; }
        }

        public class TableCell
        {
            [JsonProperty("row")]
            public int Row { get; set; }

            [JsonProperty("col")]
            public int Col { get; set; }

            [JsonProperty("children")]
            public List<LayoutNode> Children { get; set; }
        }
    }
}