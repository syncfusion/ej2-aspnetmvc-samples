using System;
using System.Collections.Generic;

namespace EJ2MVCSampleBrowser.Helpers
{
    public static class DocumentationUrlHelper
    {
        private const string MvcDocsUrl = "https://ej2.syncfusion.com/aspnetmvc/documentation/";
        private const string SdkDocsUrl = "https://help.syncfusion.com/";
        private const string SdkPlatformPath = "asp-net-mvc";
        private const string DefaultPage = "getting-started";
        private const string AspNetMvcSegment = "aspnetmvc";
        private const string GridMvcPage = "getting-started-mvc";
        private const string IntroductionSlug = "introduction";

        private static readonly Uri IntroductionUrl =
            new Uri(MvcDocsUrl + IntroductionSlug, UriKind.Absolute);

        private sealed class SdkDocumentationInfo
        {
            public SdkDocumentationInfo(string sdk, string path, string page)
            {
                Sdk = sdk;
                Path = path;
                Page = page;
            }

            public string Sdk { get; private set; }

            public string Path { get; private set; }

            public string Page { get; private set; }
        }

        private sealed class DirectDocumentationInfo
        {
            public DirectDocumentationInfo(string slug, string page)
            {
                Slug = slug;
                Page = page;
            }

            public string Slug { get; private set; }

            public string Page { get; private set; }
        }

        private static readonly Dictionary<string, SdkDocumentationInfo> ComponentSdkMap =
            new Dictionary<string, SdkDocumentationInfo>(StringComparer.OrdinalIgnoreCase)
            {
                // Grid SDK
                { "grid", new SdkDocumentationInfo("grid-sdk", "data-grid", GridMvcPage) },
                { "treegrid", new SdkDocumentationInfo("grid-sdk", "tree-grid", GridMvcPage) },
                { "pivottable", new SdkDocumentationInfo("grid-sdk", "pivot-table", DefaultPage) },

                // Chart SDK
                { "chart", new SdkDocumentationInfo("chart-sdk", "charts", DefaultPage) },
                { "threedimensionalchart", new SdkDocumentationInfo("chart-sdk", "3d-charts", DefaultPage) },
                { "circularchart3d", new SdkDocumentationInfo("chart-sdk", "3d-circular-charts", DefaultPage) },
                { "stockchart", new SdkDocumentationInfo("chart-sdk", "stock-chart", DefaultPage) },
                { "circulargauge", new SdkDocumentationInfo("chart-sdk", "circular-gauge", DefaultPage) },
                { "lineargauge", new SdkDocumentationInfo("chart-sdk", "linear-gauge", DefaultPage) },
                { "heatmapchart", new SdkDocumentationInfo("chart-sdk", "heatmap-chart", DefaultPage) },
                { "maps", new SdkDocumentationInfo("chart-sdk", "maps", DefaultPage) },
                { "rangenavigator", new SdkDocumentationInfo("chart-sdk", "range-navigator", DefaultPage) },
                { "smithchart", new SdkDocumentationInfo("chart-sdk", "smith-chart", DefaultPage) },
                { "sparkline", new SdkDocumentationInfo("chart-sdk", "sparkline-charts", DefaultPage) },
                { "barcode", new SdkDocumentationInfo("chart-sdk", "barcode-generator", DefaultPage) },
                { "sankey", new SdkDocumentationInfo("chart-sdk", "sankey-diagram", DefaultPage) },
                { "treemap", new SdkDocumentationInfo("chart-sdk", "treemap", DefaultPage) },
                { "bulletchart", new SdkDocumentationInfo("chart-sdk", "bullet-chart", DefaultPage) },
                { "dashboardlayout", new SdkDocumentationInfo("chart-sdk", "dashboard-layout", DefaultPage) },

                // File Manager SDK
                { "filemanager", new SdkDocumentationInfo("file-manager-sdk", string.Empty, DefaultPage) },

                // Gantt SDK
                { "ganttchart", new SdkDocumentationInfo("gantt-sdk", "gantt-chart", DefaultPage) },
                { "kanban", new SdkDocumentationInfo("gantt-sdk", "kanban", DefaultPage) },

                // Rich Text Editor SDK
                { "richtexteditor", new SdkDocumentationInfo("rich-text-editor-sdk", "rich-text-editor", DefaultPage) },
                { "blockeditor", new SdkDocumentationInfo("rich-text-editor-sdk", "block-editor", DefaultPage) },
                { "markdowneditor", new SdkDocumentationInfo("rich-text-editor-sdk", "markdown-editor", DefaultPage) },

                // Scheduler SDK
                { "schedule", new SdkDocumentationInfo("scheduler-sdk", "schedule", DefaultPage) },
                { "calendar", new SdkDocumentationInfo("scheduler-sdk", "calendar", DefaultPage) },
                { "datepicker", new SdkDocumentationInfo("scheduler-sdk", "date-picker", DefaultPage) },
                { "daterangepicker", new SdkDocumentationInfo("scheduler-sdk", "daterange-picker", DefaultPage) },
                { "datetimepicker", new SdkDocumentationInfo("scheduler-sdk", "datetime-picker", DefaultPage) },
                { "timepicker", new SdkDocumentationInfo("scheduler-sdk", "time-picker", DefaultPage) },

                // Diagram SDK
                { "diagram", new SdkDocumentationInfo("diagram-sdk", string.Empty, DefaultPage) }
            };

        private static readonly Dictionary<string, DirectDocumentationInfo> DirectDocumentationMap =
            new Dictionary<string, DirectDocumentationInfo>(StringComparer.OrdinalIgnoreCase)
            {
                // Direct ASP.NET MVC documentation URLs
                { "badge", new DirectDocumentationInfo("badge", GridMvcPage) },
                { "chatui", new DirectDocumentationInfo("chat-ui", DefaultPage) },
                { "aiassistview", new DirectDocumentationInfo("ai-assistview", DefaultPage) },
                { "inlineaiassist", new DirectDocumentationInfo("inline-ai-assist", DefaultPage) },
                { "speechtotext", new DirectDocumentationInfo("speech-to-text", DefaultPage) },
                { "inplaceeditor", new DirectDocumentationInfo("in-place-editor", DefaultPage) },
                { "autocomplete", new DirectDocumentationInfo("auto-complete", DefaultPage) },
                { "combobox", new DirectDocumentationInfo("combo-box", DefaultPage) },
                { "dropdownlist", new DirectDocumentationInfo("drop-down-list", DefaultPage) },
                { "multiselect", new DirectDocumentationInfo("multi-select", DefaultPage) },
                { "listbox", new DirectDocumentationInfo("list-box", DefaultPage) },
                { "dropdowntree", new DirectDocumentationInfo("drop-down-tree", DefaultPage) },
                { "multicolumncombobox", new DirectDocumentationInfo("multicolumn-combobox", DefaultPage) },
                { "contextmenu", new DirectDocumentationInfo("context-menu", DefaultPage) },
                { "progressbar", new DirectDocumentationInfo("progress-bar", DefaultPage) },
                { "fab", new DirectDocumentationInfo("floating-action-button", DefaultPage) },
                { "floatingactionbutton", new DirectDocumentationInfo("floating-action-button", DefaultPage) },
                { "imageeditor", new DirectDocumentationInfo("image-editor", DefaultPage) },
                { "textboxes", new DirectDocumentationInfo("textbox", DefaultPage) },
                { "colorpicker", new DirectDocumentationInfo("color-picker", DefaultPage) },
                { "rangeslider", new DirectDocumentationInfo("range-slider", DefaultPage) },
                { "otpinput", new DirectDocumentationInfo("otp-input", DefaultPage) },
                { "predefineddialogs", new DirectDocumentationInfo("predefined-dialogs", DefaultPage) },
                { "querybuilder", new DirectDocumentationInfo("query-builder", DefaultPage) },
                { "formrenderer", new DirectDocumentationInfo("form-renderer", DefaultPage) },

            };

        private static readonly HashSet<string> IntroductionRedirectComponents =
            new HashSet<string>(StringComparer.OrdinalIgnoreCase)
            {
                // Redirect these components to common Introduction page
                "arcgauge"
            };

        public static Uri GetGettingStartedUrl(string componentName)
        {
            var normalizedComponentName = NormalizeKey(componentName);

            if (string.IsNullOrWhiteSpace(normalizedComponentName))
            {
                return IntroductionUrl;
            }

            if (IntroductionRedirectComponents.Contains(normalizedComponentName))
            {
                return IntroductionUrl;
            }

            DirectDocumentationInfo directDocumentation;
            if (DirectDocumentationMap.TryGetValue(normalizedComponentName, out directDocumentation))
            {
                return new Uri(
                    BuildMvcDocumentationUrl(directDocumentation.Slug, directDocumentation.Page),
                    UriKind.Absolute
                );
            }

            SdkDocumentationInfo sdkDocumentation;
            if (ComponentSdkMap.TryGetValue(normalizedComponentName, out sdkDocumentation))
            {
                return new Uri(
                    BuildSdkDocumentationUrl(sdkDocumentation.Sdk, sdkDocumentation.Path, sdkDocumentation.Page),
                    UriKind.Absolute
                );
            }

            return new Uri(
                BuildMvcDocumentationUrl(NormalizeKey(componentName), DefaultPage),
                UriKind.Absolute
            );
        }

        public static Uri GetGettingStartedUrlFromPath(string requestPath)
        {
            var componentName = GetComponentNameFromPath(requestPath);
            return GetGettingStartedUrl(componentName);
        }

        private static string BuildSdkDocumentationUrl(string sdk, string path, string page)
        {
            var baseUrl = SdkDocsUrl + sdk + "/" + SdkPlatformPath;

            return string.IsNullOrWhiteSpace(path)
                ? baseUrl + "/" + page
                : baseUrl + "/" + path + "/" + page;
        }

        private static string BuildMvcDocumentationUrl(string slug, string page)
        {
            return MvcDocsUrl + slug + "/" + page;
        }

        private static string GetComponentNameFromPath(string requestPath)
        {
            if (string.IsNullOrWhiteSpace(requestPath))
            {
                return string.Empty;
            }

            var pathOnly = requestPath
                .Split('?')[0]
                .Split('#')[0];

            var segments = pathOnly.Split(
                new[] { '/' },
                StringSplitOptions.RemoveEmptyEntries
            );

            if (segments.Length == 0)
            {
                return string.Empty;
            }

            return segments.Length >= 2
                ? segments[segments.Length - 2]
                : segments[0];
        }

        private static string NormalizeKey(string value)
        {
            return (value ?? string.Empty)
                .Trim()
                .Trim('/')
                .Replace("-", string.Empty)
                .Replace("_", string.Empty)
                .Replace(" ", string.Empty)
                .ToLowerInvariant();
        }
    }
}