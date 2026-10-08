var switcherPopup;
var themeSwitherPopup;
var sdkSwitherPopup;
var openedPopup;
var searchPopup;
var settingsPopup;
var sidebar;
var settingsidebar;
var prevAction;
var searchInstance;
var isStaging = document.body.dataset.isStaging === "true";
var headerThemeSwitch = document.getElementById('header-theme-switcher');
var headerSdkSwitch = document.getElementById('header-sdk-switcher');
var settingElement = ej.base.select('.sb-setting-btn');
var notificationElement = ej.base.select('.sb-notification-btn');
var themeList = document.getElementById('themelist');
var themes = isStaging ? ['material', 'material3', 'fabric', 'fluent', 'fluent2', 'bootstrap', 'bootstrap4', 'bootstrap5', 'bootstrap5.3', 'tailwind', 'tailwind3', 'highcontrast', 'fluent2-highcontrast'] : ['material3', 'bootstrap5.3', 'fluent2', 'tailwind3', 'fluent2-highcontrast'];
var defaultTheme = 'fluent2';
var themeDropDown;
var contentTab;
var ArrayItem;
var items = [];
var sourceTab;
var isExternalNavigation = true;
var defaultTree = false;
var intialLoadCompleted = false;
var resizeManualTrigger = false;
var isMobileLeftPaneToggleBtnClicked = false;
var leftToggle = ej.base.select('#sb-toggle-left');
var sbRightPane = ej.base.select('.sb-right-pane');
var sbContentOverlay = ej.base.select('.sb-content-overlay');
var sbBodyOverlay = ej.base.select('.sb-body-overlay');
var sbHeader = ej.base.select('#sample-header');
var resetSearch = ej.base.select('.sb-reset-icon');
var urlRegex = /(npmci\.syncfusion\.com|ej2\.syncfusion\.com)(\/)(development|production)*/;
//Regex for removing hidden
var reg = /.*custom code start([\S\s]*?)custom code end.*/g;
var sampleRegex = /#\/(([^\/]+\/)+[^\/\.]+)/;
var sbArray = ['javascript', 'angular', 'react', 'typescript', 'aspcore', 'vue', 'blazor'];
var sbObj = {
    'javascript': 'javascript',
    'angular': 'angular',
    'typescript': '',
    'react': 'react',
    'aspcore': 'aspcore',
    'vue': 'vue',
    'blazor': 'blazor'
};
var matchedCurrency = {
    'en': 'USD',
    'de': 'EUR',
    'ar': 'AED',
    'zh': 'CNY',
    'fr-CH': 'CHF'
};
var searchEle = ej.base.select('#search-popup');
var inputele = ej.base.select('#search-input');
var searchOverlay = ej.base.select('.e-search-overlay');
var searchButton = document.getElementById('sb-trigger-search');
var setResponsiveElement = ej.base.select('.setting-responsive');
var isMobile = window.matchMedia('(max-width:550px)').matches;
var isCheck = window.matchMedia('(max-width:600px)').matches;
var isTablet = window.matchMedia('(min-width:600px) and (max-width: 850px)').matches;
var isPc = window.matchMedia('(min-width:850px)').matches;
var selectedTheme = location.hash.split('/')[1] || defaultTheme;
var toggleAnim = new ej.base.Animation({
    duration: 500,
    timingFunction: 'ease'
});
var controlSampleData = {};
var samplesList = getSampleList();
var samplesTreeList = [];
var execFunction = {};
var searchListView;
var sampleNameElement = document.querySelector('#component-name>.sb-sample-text');
var breadCrumbComponent = document.querySelector('.sb-bread-crumb-text>.category-text');
var breadCrumSeperator = ej.base.select('.category-seperator');
var breadCrumbSubCategory = document.querySelector('.sb-bread-crumb-text>.component');
var breadCrumbSample = document.querySelector('.sb-bread-crumb-text>.crumb-sample');
// Axe badge markup is now served inline from Views/Shared/_Layout.cshtml
// (matching ej2-aspcore-samples/Pages/Shared/_Layout.cshtml). Scripts/axe-integration.js
// binds the badge + popover once the document loads. This toolbar still hosts the
// prev/next sample navigation buttons.
var sampleNavigation = "<div class=\"sb-content-toolbar-divider\" aria-hidden=\"true\"></div>" +
    "<div class=\"sb-custom-item sample-navigation\">" +
        "<button id='prev-sample' type='button' class=\"sb-navigation-prev\" \n    aria-label=\"previous sample\">\n<span class='sb-icons sb-icon-Previous'></span>\n</button>\n" +
        "<button id='next-sample' type='button' class=\"sb-navigation-next\" aria-label=\"next sample\">\n<span class='sb-icons sb-icon-Next'></span>\n</button>\n" +
    "</div>";

var contentToolbarTemplate = sampleNavigation + '<div class="sb-icons sb-mobile-setting"></div>';
var tabContentToolbar = ej.base.createElement('div', {
    className: 'sb-content-toolbar',
    innerHTML: contentToolbarTemplate
});
var apiGrid;
window.navigateSample = (window.navigateSample !== undefined) ? window.navigateSample : function () {
    return;
};
var isInitRedirected;
var samplePath = [];
var samplesAr = [];
var currentControlID;
var currentSampleID;
var currentControl;
var newYear = new Date().getFullYear();
var copyRight = document.querySelector('.sb-footer-copyright');
copyRight.innerHTML = "Copyright © 2001 - " + newYear + " Syncfusion<sup>&reg;</sup> Inc.";
if(ej.base.registerLicense != undefined){
	ej.base.registerLicense('');
}
isMobile = window.matchMedia('(max-width:550px)').matches;
if (ej.base.Browser.isDevice || isMobile) {
    if (sidebar) {
        sidebar.destroy();
    }
    sidebar = new ej.navigations.Sidebar({
        width: '280px',
        showBackdrop: true,
        closeOnDocumentClick: true,
        enableGestures: false,
        change:resizeFunction
    });
    sidebar.appendTo('#left-sidebar');
    sidebar.hide();
} else {
    sidebar = new ej.navigations.Sidebar({
        width: '280px',
        target: document.querySelector('.sb-content '),
        showBackdrop: false,
        closeOnDocumentClick: false,
        enableGestures: false,
        change:resizeFunction
        //mediaQuery: window.matchMedia('(min-width:550px)')
    });
    sidebar.appendTo('#left-sidebar');
}

function resizeFunction() {
    if (!isMobile || isCheck) {
        resizeManualTrigger = true;
        setTimeout(cusResize(), 400);
    }
}

function cusResize() {
    var event;
    if (typeof (Event) === 'function') {
        event = new Event('resize');
    } else {
        event = document.createEvent('Event');
        event.initEvent('resize', true, true);
    }
    window.dispatchEvent(event);
}

function preventTabSwipe(e) {
    if (e.isSwiped) {
        e.cancel = true;
    }
}

function renderSbPopups() {
    switcherPopup = new ej.popups.Popup(document.getElementById('sb-switcher-popup'), {
        relateTo: document.querySelector('.sb-header-text-right'),
        position: {
            X: 'left'
        },
        collision: {
            X: 'flip',
            Y: 'flip'
        },
        offsetX: 0,
        offsetY: -15,
    });
    themeSwitherPopup = new ej.popups.Popup(document.getElementById('theme-switcher-popup'), {
        offsetY: 2,
        relateTo: document.querySelector('.theme-wrapper'),
        position: {
            X: 'left',
            Y: 'bottom'
        },
        collision: {
            X: 'flip',
            Y: 'flip'
        }
    });
    sdkSwitherPopup = new ej.popups.Popup(document.getElementById('sdk-switcher-popup'), {
        offsetX: 0,
        offsetY: 2,
        relateTo: document.querySelector('.sdk-wrapper'),
        position: {
            X: 'left',
            Y: 'bottom'
        },
        collision: {
            X: 'flip',
            Y: 'flip'
        }
    });
    searchPopup = new ej.popups.Popup(searchEle, {
        offsetY: -80,
        relateTo: inputele,
        position: {
            X: 'left',
            Y: 'bottom'
        },
        collision: {
            X: 'flip',
            Y: 'flip'
        }
    });
    settingsPopup = new ej.popups.Popup(document.getElementById('settings-popup'), {
        offsetY: 5,
        zIndex: 1001,
        relateTo: settingElement,
        position: {
            X: 'right',
            Y: 'bottom'
        },
        collision: {
            X: 'flip',
            Y: 'flip'
        }
    });
    settingsidebar = new ej.navigations.Sidebar({
        position: 'Right',
        width: '282',
        zIndex: '1003',
        showBackdrop: true,
        type: 'Over',
        enableGestures: false,
    });
    settingsidebar.appendTo('#right-sidebar');
    if (!isMobile) {
        settingsidebar.hide();
        settingsPopup.hide();
    } else {
        ej.base.select('.sb-mobile-preference').appendChild(ej.base.select('#settings-popup'));
    }
    searchPopup.hide();
    switcherPopup.hide();
    themeSwitherPopup.hide();
    themeDropDown = new ej.dropdowns.DropDownList({
        index: 0,
        change: function (e) {
            function isDarkModeURL() {
                return window.location.href.includes('-dark');
            }
            var localtheme = localStorage.getItem("currentTheme") || location.hash.split('/')[1] || defaultTheme;
            // If "-dark" is present in the URL, modify the value accordingly
            if (localtheme != null && localtheme.includes("-dark") && e.value != "highcontrast" && e.value != "fluent2-highcontrast" && e.value != "bootstrap4") {
                if (isDarkModeURL() || window.location.href.includes('highcontrast') || window.location.href.includes('fluent2-highcontrast') || window.location.href.includes('bootstrap4')) {
                    e.value += "-dark";
                    switchTheme(e.value);
                }
            }
            else {
                switchTheme(e.value);
            }
        }
    });
  
    modeDropDown = new ej.dropdowns.DropDownList({
        change: function (e) {
            var Current_url = window.location.href;
            var hashValue = Current_url.split("#/");
            var themeValue = hashValue[1];
            if (themeValue.includes("-dark")) {
                // Remove "-dark" from the hash 
                themeValue = themeValue.replace("-dark", "");
            }
            function isDarkModeURL() {
                return window.location.href.includes('-dark');
            }
            if (isDarkModeURL() && e.value === 'dark') {
                return;
            } else {
                if (e.value == 'dark') {
                    switchTheme(themeValue + "-dark");
                    localStorage.setItem("currentTheme", themeValue+"-dark");
                } else {
                    localStorage.setItem("currentTheme", themeValue);
                    switchTheme(themeValue);
                }
               location.reload();
            }
        }
    });


    
    modeDropDown.appendTo('#sb-setting-mode');
    themeDropDown.appendTo('#sb-setting-theme');
    cultureDropDown = new ej.dropdowns.DropDownList({
        value: sessionStorage.getItem("ej2-culture") || 'en',
        change: function (e) {
            sessionStorage.setItem('ej2-culture', e.value);
            sessionStorage.removeItem('ej2-currency');
            cultureDropDown.hidePopup();
            location.reload();
        }
    });
    currencyDropDown = new ej.dropdowns.DropDownList({
        value: sessionStorage.getItem("ej2-currency") || matchedCurrency[cultureDropDown.value],
        change: function (e) {
            ej.base.setCurrencyCode(e.value);
            sessionStorage.setItem('ej2-currency', e.value);
            currencyDropDown.hidePopup();
        }
    });
    currencyDropDown.appendTo('#sb-setting-currency');
    cultureDropDown.appendTo('#sb-setting-culture');
    contentTab = new ej.navigations.Tab({
        selected: changeTab,
        selecting: preventTabSwipe,
        selected: function (e) {
            if (e.selectedIndex == 1) {
                sourceTab.items = ArrayItem;
                sourceTab.refresh();
                renderCopyCode();
                dynamicTabCreation(sourceTab);
            }
        }
    }, '#sb-content');
    sourceTab = new ej.navigations.Tab({
        items: [],
        headerPlacement: 'Bottom',
        cssClass: 'sb-source-code-section',
        created: dynamicTabCreation,
        selecting: preventTabSwipe,
        selected: function (e) {
            if (e.selectedIndex === 0) {
                renderCopyCode();
            }
            if (e.isSwiped) {
                e.cancel = true;
            }
            var sourceEle = document.querySelector('#sb-source-tab > .e-content > #e-content' + this.tabId + '_' + e.selectedIndex).children[0];
            sourceEle.innerHTML = items[e.selectedIndex].data;
            sourceEle.innerHTML = sourceEle.innerHTML.replace(reg, '');
            sourceEle.classList.add('sb-src-code');
            sourceEle.style.height = "500px";
            sourceEle.style.overflowY = "auto";
            sourceEle.setAttribute("tabindex", "0");
            hljs.highlightBlock(sourceEle);
        }
    }, '#sb-source-tab');
    sourceTab.selectedItem = 1;
    var prevbutton = new ej.buttons.Button({
        iconCss: 'sb-icons sb-icon-Previous',
        cssClass: 'e-flat'
    }, '#mobile-prev-sample');
    var nextbutton = new ej.buttons.Button({
        iconCss: 'sb-icons sb-icon-Next',
        cssClass: 'e-flat',
        iconPosition: 'right'
    }, '#mobile-next-sample');

    // The axe badge host is rendered by Scripts/axe-integration.js into
    // #sf-axe-toolbar-host. Here we graft the existing splitter + prev/next
    // nav toolbar AFTER the badge so the WCAG pill sits to the LEFT of the
    // splitter with the navigation buttons to the right.
    var axeBadgeHost = document.getElementById('sf-axe-toolbar-host');
    if (axeBadgeHost && tabContentToolbar) {
        // The toolbar (splitter + nav) renders absolute right-aligned. Since
        // the axe host is itself absolutely positioned, the toolbar floats to
        // the right of the toolbar host on the same row as the badge.
        axeBadgeHost.appendChild(tabContentToolbar);
    }
    var previous = new ej.popups.Tooltip({
        content: 'Previous Sample'
    });
    previous.appendTo('#prev-sample');

    var next = new ej.popups.Tooltip({
        content: 'Next Sample'
    });

    next.appendTo('#next-sample');

    // WCAG 2.2 AA badge + native popover live in the sample navigation row
    // (rendered by sampleNavigation above). All behaviour — hover/focus open,
    // leave-close, click toggle, Escape, scan + report — is owned by
    // Scripts/axe-integration.js via initAxeBadge().
}
function loadCulture(cul) {
    var url = window.location.href;
    if (cul != 'en') {
        var locale = new ej.base.Ajax('../Scripts/locale/' + cul + '.json', 'GET', false);
        locale.send().then(function (value) {
            ej.base.L10n.load(JSON.parse(value));
        });
    }
    var ajax = new ej.base.Ajax('../Scripts/cldr-data/main/' + cul + '/all.json', 'GET', false);
    if (!url.includes("richtexteditor") && !url.includes("markdowneditor") && !url.includes("filemanager") || cul !== 'en') {
        ajax.send().then(function (result) {
            ej.base.loadCldr(JSON.parse(result));
            changeCulture(cul);
        });
    }
}
function changeCulture(cul) {
    setTimeout(function () {
        if (cul === 'ar') {
            changeRtl(true);
        }
        ej.base.setCurrencyCode(sessionStorage.getItem("ej2-currency") || matchedCurrency[cul])
        ej.base.setCulture(cul); // Set the culture after components are ready
    },0);
}
function changeRtl(bool) {
    var elementlist = ej.base.selectAll('.e-control', ej.base.select('.control-section'));
    for (var i = 0; i < elementlist.length; i++) {
        var control = elementlist[i];
        if (control.classList.contains('e-richtexteditor')) {
            control.ej2_instances = control.getElementsByTagName("textArea")[0].ej2_instances;
        }
        if (control.ej2_instances) {
            for (var a = 0; a < control.ej2_instances.length; a++) {
                var instance = control.ej2_instances[a];
                instance.enableRtl = bool;
            }
        }
    }
}
function renderCopyCode() {
    var ele = ej.base.createElement('div', {
        className: 'copy-tooltip',
        innerHTML: '<div class="e-icons copycode"></div>'
    });
    document.getElementById('sb-source-tab').appendChild(ele);
    ele.addEventListener('click', copyCode);
    var copiedTooltip = new ej.popups.Tooltip({
        content: 'Copied to clipboard ',
        position: 'BottomCenter',
        opensOn: 'Click',
        closeDelay: 50
    }, '.copy-tooltip');

}

function changeTab(args) {
    if (args.selectedIndex === 2) {
        var hash = location.hash.split('/');
        var data = window.apiList[hash[2] + '/' + hash[3].replace('.html', '')] || [];
        if (data.length) {
            apiGrid.dataSource = data;
        } else {
            apiGrid.dataSource = [];
        }
    }
}

function dynamicTabCreation(obj) {
    var tabObj
    if (obj) {
        tabObj = obj;
    } else {
        tabObj = this;
    }
    var contentEle = tabObj.element.querySelector('#e-content' + tabObj.tabId + '_' + tabObj.selectedItem);
    if (!contentEle) {
        return;
    }
    var blockEle = tabObj.element.querySelector('#e-content' + tabObj.tabId + '_' + tabObj.selectedItem).children[0];
    blockEle.innerHTML = tabObj.items[tabObj.selectedItem].data;
    blockEle.innerHTML = blockEle.innerHTML.replace(reg, '');
    blockEle.classList.add('sb-src-code');
    blockEle.style.height = "500px";
    blockEle.style.overflowY = "auto";
    blockEle.setAttribute("tabindex", "0");
    if (blockEle) {
        hljs.highlightBlock(blockEle);
    }
}

function dataBound(args) {
    var gridtrs = this.getRows().length;
    var trs = this.getRows();
    for (var count = 0; count < gridtrs; count++) {
        var tr1 = trs[count];
        if (tr1.getBoundingClientRect().height > 100) {
            var desDiv = tr1.querySelector('.sb-sample-description');
            var tag = ej.base.createElement('a', {
                id: 'showtag',
                innerHTML: ' show more...'
            });
            tag.addEventListener('click', tagShowmore.bind(this, desDiv));
            desDiv.classList.add('e-custDesription');
            desDiv.appendChild(tag);
        }
    }
}

function tagShowmore(target) {
    target.classList.remove('e-custDesription');
    target.querySelector('#showtag').classList.add('e-display');
    var hideEle = target.querySelector('#hidetag');
    if (!hideEle) {
        var tag = ej.base.createElement('a', {
            id: 'hidetag',
            attrs: {},
            innerHTML: 'hide less..'
        });
        target.appendChild(tag);
        tag.addEventListener('click', taghideless.bind(this, target));
    } else {
        hideEle.classList.remove('e-display');
    }
}

function taghideless(target) {
    target.querySelector('#hidetag').classList.add('e-display');
    target.querySelector('#showtag').classList.remove('e-display');
    target.classList.add('e-custDesription');
}

function setPressedAttribute(ele) {
    var status = ele.classList.contains('active');
    ele.setAttribute('aria-pressed', status ? 'true' : 'false');
}

function sbHeaderClick(action, preventSearch) {
    if (openedPopup) {
        openedPopup.hide(new ej.base.Animation({
            name: 'FadeOut',
            duration: 300,
            delay: 0
        }));
    }
    if (preventSearch !== true && !searchOverlay.classList.contains('sb-hide')) {
        searchOverlay.classList.add('sb-hide');
        searchButton.classList.remove('active');
        setPressedAttribute(searchButton);
    }
    var curPopup;
    switch (action) {
        case 'changeSampleBrowser':
            curPopup = switcherPopup;
            break;
        case 'changeTheme':
            headerThemeSwitch.classList.toggle('active');
            settingElement.classList.remove('active');
            headerSdkSwitch.classList.remove('active');
            setPressedAttribute(headerThemeSwitch);
            curPopup = themeSwitherPopup;
            break;
        case 'changeSdk':
            headerSdkSwitch.classList.toggle('active');
            settingElement.classList.remove('active');
            headerThemeSwitch.classList.remove('active');
            setPressedAttribute(headerSdkSwitch);
            curPopup = sdkSwitherPopup;
            break;
        case 'toggleSettings':
            settingElement.classList.toggle('active');
            headerThemeSwitch.classList.remove('active');
            headerSdkSwitch.classList.remove('active');
            setPressedAttribute(settingElement);
            themeDropDown.index = themes.indexOf(selectedTheme);
            curPopup = settingsPopup;
            break;
    }
    if (action === 'closePopup') {
        headerThemeSwitch.classList.remove('active');
        headerSdkSwitch.classList.remove('active');
        settingElement.classList.remove('active');
    }
    if (curPopup && curPopup !== openedPopup) {
        curPopup.show(new ej.base.Animation({
            name: 'FadeIn',
            duration: 400,
            delay: 0
        }));
        openedPopup = curPopup;
    } else {
        openedPopup = null;
    }
    prevAction = action;
}

function toggleSearchOverlay() {
    sbHeaderClick('closePopup', true);
    inputele.value = '';
    searchPopup.hide();
    searchButton.classList.toggle('active');
    setPressedAttribute(searchButton);
    searchOverlay.classList.toggle('sb-hide');
    if (!searchOverlay.classList.contains('sb-hide')) {
        inputele.focus();
    }
}

function changeTheme(e) {
    var target = e.target;
    target = ej.base.closest(target, 'li');
    var themeName = target.id;
    if (!isStaging) {
        themeName = themeName === 'bootstrap5.3' ? 'bootstrap5' : themeName;
    }
    var storedURL = localStorage.getItem('PreviousURL');
    if (storedURL != null && storedURL.includes("-dark") && themeName != "highcontrast" && themeName != "fluent2-highcontrast" && themeName != "bootstrap4") {
        themeName = themeName + "-dark";
    } else {
        themeName = themeName;
    }
    switchTheme(themeName);
    var imageEditorElem = document.querySelector(".e-image-editor");
    if (imageEditorElem != null) {
        var imageEditor = ej.base.getComponent(document.getElementById(imageEditorElem.id), 'image-editor');
        imageEditor.theme = themeName;
    }
}

function switchTheme(str) {
    var hash = location.hash.split('/');
    if (!isStaging) {
        str = str === 'bootstrap5.3' ? 'bootstrap5' : str === 'bootstrap5.3-dark' ? 'bootstrap5-dark' : str;
    }
    if (hash[1] !== str) {
        hash[1] = str;
        localStorage.setItem('ej2-switch', ej.base.select('.sb-responsive-section .active').id);
        location.hash = hash.join('/');
        location.reload();
    }
}

// ===== SDK Switcher =====
function changeSdk(e) {
    var target = e.target;
    target = ej.base.closest(target, 'li');
    if (!target) { return; }
    var sdkName = target.id;
    // Map new DOM IDs to old SDK names for URL parameters
    sdkName = mapDomIdToSdkId(sdkName);
    // The 'StandaloneGroup' li is the group header for the standalone SDKs.
    // Clicking it should toggle the group's expand/collapse state, NOT change
    // the active SDK or navigate.
    if (sdkName === 'StandaloneGroup') {
        e.stopPropagation();
        e.preventDefault();
        return;
    }
    // The 'DocumentSolutionsGroup' li is the group header for the
    // Document Solutions children. Clicking it toggles the group's
    // expand/collapse state, exactly like StandaloneGroup.
    if (sdkName === 'DocumentSolutionsGroup') {
        e.stopPropagation();
        e.preventDefault();
        var docGroup = document.getElementById('DocumentSolutionsGroup');
        if (docGroup) {
            var isExpanded = docGroup.getAttribute('aria-expanded') === 'true';
            docGroup.setAttribute('aria-expanded', isExpanded ? 'false' : 'true');
        }
        return;
    }
    // The four Document Solutions children (DocumentSDK, PdfViewerSDK,
    // DocxEditorSDK, SpreadsheetEditorSDK) all carry data-no-active="true"
    // and are not part of the active SDK. Clicking one opens the
    // corresponding Document Solutions demo in a new browser tab. They
    // must not be marked as the active SDK, must not change the URL or
    // sdk query param, and must not navigate to a default sample path.
    if (target.getAttribute('data-no-active') === 'true') {
        e.stopPropagation();
        e.preventDefault();
        var docSolutionUrls = {
            'DocumentSDK': 'https://document.syncfusion.com/#/document-sdk',
            'PdfViewerSDK': 'https://document.syncfusion.com/demos/pdf-viewer/asp-net-mvc/pdfviewer/default#/tailwind3',
            'DocxEditorSDK': 'https://document.syncfusion.com/demos/docx-editor/asp-net-mvc/documenteditor/default',
            'SpreadsheetEditorSDK': 'https://document.syncfusion.com/demos/spreadsheet-editor/asp-net-mvc/spreadsheet/defaultfunctionalities'
        };
        var targetUrl = docSolutionUrls[sdkName];
        if (targetUrl) {
            window.open(targetUrl, '_blank', 'noopener,noreferrer');
        }
        return;
    }
    // Mark active state.
    var sdkList = document.getElementById('sdklist');
    if (sdkList) {
        var items = sdkList.querySelectorAll('li');
        for (var i = 0; i < items.length; i++) {
            // Don't clear the active state of the StandaloneGroup parent
            // (it's not a selectable item but a group header).
            if (items[i].id !== 'StandaloneGroup') {
                items[i].classList.remove('active');
            }
        }
        target.classList.add('active');
        // Update the SDK switcher trigger text to reflect the active SDK.
        var labelSpan = target.querySelector('.switch-text');
        var activeText = document.querySelector('#header-sdk-switcher .sb-sdk-active-text');
        if (labelSpan && activeText) {
            activeText.textContent = labelSpan.textContent.trim();
        }
        // Also update the mobile secondary header SDK switcher label.
        var mobileActiveText = document.querySelector('#header-sdk-switcher-mobile .sb-sdk-active-text');
        if (labelSpan && mobileActiveText) {
            mobileActiveText.textContent = labelSpan.textContent.trim();
        }
        // Auto-expand the Standalone group when a child is selected, so the user
        // can see the active child after the page reloads.
        var group = document.getElementById('StandaloneGroup');
        if (group) {
            var standaloneChildIds = ['Grid', 'Charts', 'Scheduler', 'Gantt', 'RichTextEditor', 'Diagram', 'FileManager'];
            if (standaloneChildIds.indexOf(sdkName) !== -1) {
                group.setAttribute('aria-expanded', 'true');
            } else {
                group.setAttribute('aria-expanded', 'false');
            }
        }
    }
    // Get the current theme from the URL hash
    var currentTheme = (location.hash.split('/')[1]) || defaultTheme;
    // If the clicked item is already the active SDK, do not navigate/reload -
    // just close the popup. This mirrors how the theme and language switchers
    // behave when re-selecting the current value.
    var urlParamsCheck = new URLSearchParams(window.location.search);
    var currentSdkParam = (urlParamsCheck.get('sdk') || '').toLowerCase();
    var alreadyActive = (sdkName === 'UIEdition' && !currentSdkParam) ||
        (sdkName !== 'UIEdition' && currentSdkParam === sdkName.toLowerCase());
    if (alreadyActive && target.classList.contains('active')) {
        if (typeof closeSdkPopup === 'function') {
            closeSdkPopup();
        } else if (sdkSwitherPopup && typeof sdkSwitherPopup.hide === 'function') {
            sdkSwitherPopup.hide();
        }
        return;
    }
    // 'UIEdition' is a special case: navigate to the default grid sample WITHOUT
    // any sdk query param in the URL.
    if (sdkName === 'UIEdition') {
        var defaultPath = getDefaultSampleForSdk('UIEdition') || 'Grid/GridOverview';
        var basePath = location.pathname.split('/').slice(0, -2).join('/');
        var newUrl = location.origin + basePath + '/' + defaultPath + '#/' + currentTheme;
        window.location.href = newUrl;
        return;
    }
    // Build the new URL. Always include the sdk query param (lowercase).
    var defaultPath = getDefaultSampleForSdk(sdkName);
    if (defaultPath) {
        var basePath2 = location.pathname.split('/').slice(0, -2).join('/');
        var queryString = '?sdk=' + encodeURIComponent(sdkName.toLowerCase());
        var newUrl2 = location.origin + basePath2 + '/' + defaultPath + queryString + '#/' + currentTheme;
        window.location.href = newUrl2;
    } else {
        // Fallback: just update query param
        var url = new URL(window.location.href);
        url.searchParams.set('sdk', sdkName.toLowerCase());
        window.location.href = url.toString();
    }
}

function handleSdkKeyboard(e) {
    var key = e.key;
    var target = e.target;
    var sdkList = document.getElementById('sdklist');
    if (!sdkList) { return; }
    // Fall back to the active item (or the first selectable item) when focus
    // is on the SDK trigger button instead of a list item.
    var currentItem = ej.base.closest(target, 'li');
    if (!currentItem || !sdkList.contains(currentItem)) {
        currentItem = sdkList.querySelector('li.active') || sdkList.querySelector('li');
    }
    if (!currentItem) { return; }

    var allItems = sdkList.querySelectorAll('li');
    var visibleItems = [];
    for (var i = 0; i < allItems.length; i++) {
        var item = allItems[i];
        var parentGroup = item.getAttribute('data-sdk-group');
        if (parentGroup) {
            var parent = document.getElementById(parentGroup);
            if (parent && parent.getAttribute('aria-expanded') === 'false') {
                continue; // Hide children of collapsed groups.
            }
        }
        visibleItems.push(item);
    }

    var currentIndex = -1;
    for (var j = 0; j < visibleItems.length; j++) {
        if (visibleItems[j] === currentItem) {
            currentIndex = j;
            break;
        }
    }

    var nextItem = null;

    switch (key) {
        case 'ArrowDown':
            if (currentIndex >= 0 && currentIndex < visibleItems.length - 1) {
                nextItem = visibleItems[currentIndex + 1];
            } else if (currentIndex === -1 && visibleItems.length > 0) {
                nextItem = visibleItems[0];
            }
            e.preventDefault();
            break;
        case 'ArrowUp':
            if (currentIndex > 0) {
                nextItem = visibleItems[currentIndex - 1];
            } else if (currentIndex === -1 && visibleItems.length > 0) {
                nextItem = visibleItems[0];
            }
            e.preventDefault();
            break;
        case 'Enter':
            var clickEvent = new MouseEvent('click', {
                bubbles: true,
                cancelable: true,
                view: window
            });
            currentItem.dispatchEvent(clickEvent);
            e.preventDefault();
            break;
        case 'Escape':
            if (sdkSwitherPopup) {
                sdkSwitherPopup.hide();
            }
            // Restore focus to whichever trigger was used to open this popup.
            // The trigger remembers whether the desktop (header-sdk-switcher)
            // or mobile (sample-header-secondary › header-sdk-switcher-mobile)
            // button was last focused via document.activeElement.
            try {
                var previouslyFocused = document.activeElement;
                if (previouslyFocused && previouslyFocused.closest &&
                    previouslyFocused.closest('#header-sdk-switcher-mobile')) {
                    var mobileTrigger = document.getElementById('header-sdk-switcher-mobile');
                    if (mobileTrigger && typeof mobileTrigger.focus === 'function') {
                        mobileTrigger.focus();
                    }
                } else if (headerSdkSwitch && typeof headerSdkSwitch.focus === 'function') {
                    headerSdkSwitch.focus();
                }
            } catch (focusErr) { /* ignore focus restoration failures */ }
            e.preventDefault();
            break;
    }

    if (nextItem && typeof nextItem.focus === 'function') {
        nextItem.focus();
    }
}

// Returns the default control/sample path for a given SDK id (e.g. 'Charts' -> 'Chart/Overview')
// Case-insensitive: accepts both 'Grid' and 'grid' as input.
function getDefaultSampleForSdk(sdkId) {
    var mapping = {
        'UIEdition': 'Grid/GridOverview',
        'Grid': 'Grid/GridOverview',
        'Charts': 'Chart/Overview',
        'Diagram': 'Diagram/DefaultFunctionalities',
        'Gantt': 'GanttChart/OverView',
        'FileManager': 'FileManager/Overview',
        'Scheduler': 'Schedule/Overview',
        'RichTextEditor': 'RichTextEditor/Overview'
    };
    if (mapping[sdkId]) {
        return mapping[sdkId];
    }
    var lower = (sdkId || '').toLowerCase();
    for (var key in mapping) {
        if (key.toLowerCase() === lower) {
            return mapping[key];
        }
    }
    return null;
}

function mapSdkIdToDisplayName(sdkId) {
    var mapping = {
        'Grid': 'Grid SDK',
        'Charts': 'Chart SDK',
        'Diagram': 'Diagram SDK',
        'Gantt': 'Gantt SDK',
        'FileManager': 'FileManager SDK',
        'Scheduler': 'Scheduler SDK',
        'RichTextEditor': 'RTE SDK'
    };
    if (mapping[sdkId]) {
        return mapping[sdkId];
    }
    var lower = (sdkId || '').toLowerCase();
    for (var k in mapping) {
        if (k.toLowerCase() === lower) {
            return mapping[k];
        }
    }
    return null;
}

// Returns a dictionary (directory -> true) of all components that match the current SDK
// resolved from the URL query parameter. Returns null when the SDK cannot be determined,
// indicating that the search results should not be filtered.
function getAllowedDirectoriesForCurrentSdk() {
    var knownIds = ['Grid', 'Charts', 'Diagram', 'Gantt', 'FileManager', 'Scheduler', 'RichTextEditor'];
    var urlParams = new URLSearchParams(window.location.search);
    var rawSdk = urlParams.get('sdk');
    var resolvedSdk = null;
    if (rawSdk) {
        for (var k = 0; k < knownIds.length; k++) {
            if (knownIds[k].toLowerCase() === rawSdk.toLowerCase()) {
                resolvedSdk = knownIds[k];
                break;
            }
        }
    }
    if (!resolvedSdk) {
        return null; // No filter; show everything.
    }
    var sdkDisplayName = mapSdkIdToDisplayName(resolvedSdk);
    if (!sdkDisplayName) {
        return null;
    }
    var allowed = {};
    var all = (window.samplesList || []);
    for (var i = 0; i < all.length; i++) {
        var comp = all[i];
        if (comp && comp.Sdk && comp.Sdk.indexOf(sdkDisplayName) !== -1 && comp.directory) {
            allowed[comp.directory.toLowerCase()] = true;
        }
    }
    return allowed;
}

function filterSamplesBySdk(list, sdkName) {
    var filtered = [];
    for (var i = 0; i < list.length; i++) {
        var component = list[i];
        if (component && component.Sdk && component.Sdk.indexOf(sdkName) !== -1) {
            filtered.push(component);
        }
    }
    return filtered;
}

// Returns the SDK query string portion of the URL (e.g. '?sdk=Grid') or empty string if not present
function getSdkQueryString() {
    return location.search && location.search.indexOf('sdk=') !== -1 ? location.search : '';
}

// Repopulate controlSampleData from the full unfiltered list so the right-hand
// list view always has data even when the SDK filter is active.
function initializeAllControlSampleData() {
    var fullList = window._fullSamplesList || window.samplesList;
    for (var i = 0; i < fullList.length; i++) {
        var component = fullList[i];
        if (component && component.samples) {
            var dirKey = component.directory.toLowerCase();
            if (!controlSampleData[dirKey]) {
                controlSampleData[dirKey] = getSamples(component.samples);
            }
        }
    }
}

// Bootstrap the SDK popup state from the URL on every page load
// Maps new DOM IDs to old SDK names (for URL parameters)
function mapDomIdToSdkId(domId) {
    var mapping = {
        'sdk-switch-grid': 'Grid',
        'sdk-switch-Charts': 'Charts',
        'sdk-switch-scheduler': 'Scheduler',
        'sdk-switch-gantt': 'Gantt',
        'sdk-switch-richtexteditor': 'RichTextEditor',
        'sdk-switch-diagram': 'Diagram',
        'sdk-switch-fileManager': 'FileManager'
    };
    return mapping[domId] || domId;
}

function getSdkSwitcher() {
    if (!sdkSwitherPopup) {
        sdkSwitherPopup = document.getElementById('sdk-switcher-popup').ej2_instances
            ? document.getElementById('sdk-switcher-popup').ej2_instances[0]
            : null;
    }
    var knownIds = ['UIEdition', 'Grid', 'Charts', 'Diagram', 'Gantt', 'FileManager', 'Scheduler', 'RichTextEditor'];
    var labelMap = {
        'UIEdition': 'All Demos',
        'Grid': 'Grid SDK',
        'Charts': 'Chart SDK',
        'Diagram': 'Diagram SDK',
        'Gantt': 'Gantt SDK',
        'FileManager': 'File Manager SDK',
        'Scheduler': 'Scheduler SDK',
        'RichTextEditor': 'Rich Text Editor SDK'
    };
    var urlParams = new URLSearchParams(window.location.search);
    var rawSdk = urlParams.get('sdk');
    var currentSdk = null;
    var isUiEdition = !rawSdk;
    if (rawSdk) {
        for (var k = 0; k < knownIds.length; k++) {
            if (knownIds[k].toLowerCase() === rawSdk.toLowerCase()) {
                currentSdk = knownIds[k];
                break;
            }
        }
    }
    // If sdk query param is invalid, remove the invalid value from the URL and reload
    if (!currentSdk && rawSdk) {
        var cleanUrl = new URL(window.location.href);
        cleanUrl.searchParams.delete('sdk');
        window.location.replace(cleanUrl.toString());
        return;
    }
    var sdkList = document.getElementById('sdklist');
    if (sdkList) {
        var items = sdkList.querySelectorAll('li');
        for (var i = 0; i < items.length; i++) {
            // Don't clear the active state of the StandaloneGroup parent
            // (it's not a selectable item but a group header).
            if (items[i].id !== 'StandaloneGroup') {
                items[i].classList.remove('active');
            }
        }
        var activeId = currentSdk || (isUiEdition ? 'UIEdition' : null);
        var activeLabel = '';
        if (activeId) {
            for (var j = 0; j < items.length; j++) {
                if (items[j].id === activeId) {
                    items[j].classList.add('active');
                    var labelSpan = items[j].querySelector('.switch-text');
                    if (labelSpan) {
                        activeLabel = labelSpan.textContent.trim();
                    }
                    break;
                }
            }
        }
        // Bind the active SDK label to the SDK switcher button text.
        var activeText = document.querySelector('#header-sdk-switcher .sb-sdk-active-text');
        if (activeText) {
            activeText.textContent = activeLabel || labelMap['UIEdition'];
        }
        // Also update the mobile secondary header SDK switcher label.
        var mobileActiveText = document.querySelector('#header-sdk-switcher-mobile .sb-sdk-active-text');
        if (mobileActiveText) {
            mobileActiveText.textContent = activeLabel || labelMap['UIEdition'];
        }
        // Auto-expand the Standalone UI SDK group if a child is currently the active selection.
        var group = document.getElementById('StandaloneGroup');
        if (group) {
            var standaloneChildIds = ['Grid', 'Charts', 'Scheduler', 'Gantt', 'RichTextEditor', 'Diagram', 'FileManager'];
            if (standaloneChildIds.indexOf(currentSdk) !== -1) {
                group.setAttribute('aria-expanded', 'true');
            } else {
                group.setAttribute('aria-expanded', 'false');
            }
            // Wire click-to-toggle for the Standalone UI SDK group header. The
            // header itself is not selectable (clicking it should not change the
            // URL/active SDK), only expand/collapse its child items.
            if (!group.dataset.boundToggle) {
                group.dataset.boundToggle = 'true';
                group.addEventListener('click', function (ev) {
                    var li = ev.target;
                    while (li && li !== group && li.parentNode) {
                        li = li.parentNode;
                    }
                    if (li !== group) { return; }
                    ev.preventDefault();
                    ev.stopPropagation();
                    var expanded = group.getAttribute('aria-expanded') === 'true';
                    group.setAttribute('aria-expanded', expanded ? 'false' : 'true');
                });
            }
        }
        // Document Solutions items are external-only (data-no-active="true") and
        // none of the known SDK ids maps to a Document Solutions child, so the
        // group is always collapsed on initial load.
        var docGroup = document.getElementById('DocumentSolutionsGroup');
        if (docGroup) {
            docGroup.setAttribute('aria-expanded', 'false');
        }
    }
    // Sync the URL.
    if (currentSdk) {
        var expectedSdkParam = currentSdk.toLowerCase();
        if (!rawSdk || rawSdk.toLowerCase() !== expectedSdkParam) {
            var newUrl = new URL(window.location.href);
            newUrl.searchParams.set('sdk', expectedSdkParam);
            window.history.replaceState({}, '', newUrl.toString());
        }
    } else if (isUiEdition && rawSdk) {
        var cleanUrl2 = new URL(window.location.href);
        cleanUrl2.searchParams.delete('sdk');
        window.history.replaceState({}, '', cleanUrl2.toString());
    }
}

function onsearchInputChange(e) {
    if (e.keyCode === 27) {
        toggleSearchOverlay();
    }
    var searchString = e.target.value;
    if (searchString.length <= 2) {
        searchPopup.hide();
        return;
    }
    var val = [];
    val = searchInstance.search(searchString, {
        fields: {
            component: {
                boost: 1
            },
            name: {
                boost: 2
            }
        },
        expand: true,
        boolean: 'AND'
    });
    // Filter search results to only include components in the active SDK
    var allowedDirs = getAllowedDirectoriesForCurrentSdk();
    if (allowedDirs) {
        var sdkFiltered = [];
        for (var sf = 0; sf < val.length; sf++) {
            var docDir = (val[sf].doc && val[sf].doc.dir) ? val[sf].doc.dir.toLowerCase() : '';
            if (docDir && allowedDirs[docDir]) {
                sdkFiltered.push(val[sf]);
            }
        }
        val = sdkFiltered;
    }
    var value = [];
    if (ej.base.Browser.isDevice) {
        for (var j = 0; j < val.length; j++) {
            if (val[j].doc.hideOnDevice !== true) {
                value = value.concat(val);
            }
        }
    }
    var searchVal = ej.base.Browser.isDevice ? value : val;
    if (searchVal.length) {
        var data = new ej.data.DataManager(searchVal);
        var controls = data.executeLocal(new ej.data.Query().take(10).select('doc'));
        var controlsAccess = [];
        for (var i = 0, controls = controls; i < controls.length; i++) {
            var cont = controls[i];
            controlsAccess.push(cont.doc);
        }
        controls = controlsAccess;
        var count = 1;
        var controlCollection = {};
        controlCollection[controls[0].component] = count;
        controls[0].sortId = count;
        for (var i = 1; i < controls.length; i++) {
            var curComponent = controls[i].component;
            var previd = controlCollection[curComponent];
            if (previd) {
                controls[i].sortId = previd;
            } else {
                ++count;
                controlCollection[curComponent] = count;
                controls[i].sortId = count;
            }
        }
        if (!searchListView) {
            searchListView = new ej.lists.ListView({
                dataSource: controls,
                fields: {
                    id: 'uid',
                    text: 'name',
                    groupBy: 'sortId'
                },
                select: controlSelect,
                template: '<div role="list" class="e-text-content e-icon-wrapper" data="${dir}/${url}" uid="${uid}" pid="${parentId}">' +
                    '<span class="e-list-text" role="listitem">' +
                    '${name}</span></div>',
                groupTemplate: '${if(items[0]["component"])}<div class="e-text-content"><span class="e-search-group">${items[0].component}</span>' +
                    '</div>${/if}',
                actionComplete: function () {
                    var searchValue = ej.base.select('#search-input').value;
                    highlight(searchValue, this.element);
                }
            }, searchPopup.element);
        } else {
            searchListView.dataSource = controls;
        }
        searchPopup.show();
    } else {
        searchPopup.element.innerHTML = '<div class="search-no-record">We are sorry. We cannot find any matches for your search term.</div>';
        searchPopup.show();
    }
}

function highlight(searchString, listElement) {
    var regex = new RegExp(searchString.split(' ').join('|'), 'gi');
    var contentElements = ej.base.selectAll('.e-list-item .e-text-content .e-list-text', listElement);
    for (var i = 0; i < contentElements.length; i++) {
        var spanText = ej.base.select('.sb-highlight', contentElements[i]);
        if (spanText) {
            contentElements[i].innerHTML = contentElements[i].text;
        }
        contentElements[i].innerHTML = contentElements[i].innerHTML.replace(regex, function (matched) {
            return '<span class="sb-highlight">' + matched + '</span>';
        });
    }
}

function setMouseOrTouch(e) {
    var ele = ej.base.closest(e.target, '.sb-responsive-items');
    var switchType = ele.id;
    var modeType = document.body.classList.contains("e-bigger") ? "touch" : "mouse";
    changeMouseOrTouch(switchType);
    sbHeaderClick('closePopup');
    localStorage.setItem('ej2-switch', switchType);
    if (!(switchType == modeType)) {
        location.reload();
    }
}

function onNextButtonClick(arg) {
    sampleOverlay();
    var theme = location.href.split('/')[5] || defaultTheme;
    var curSampleUrl = location.pathname;
    var inx = samplesAr.indexOf(curSampleUrl);
    if (inx !== -1) {
        var prevhref = samplesAr[inx];
        var curhref = samplesAr[inx + 1];
        location.href = location.origin + curhref + '#/' + theme;
    }
    window.hashString = location.origin + '/' + curhref + '#/' + theme;
    setSelectList();
}

function onPrevButtonClick(arg) {
    sampleOverlay();
    var theme = location.href.split('/')[5] || defaultTheme;
    var curSampleUrl = location.pathname;
    var inx = samplesAr.indexOf(curSampleUrl);
    if (inx !== -1) {
        var prevhref = samplesAr[inx];
        var curhref = samplesAr[inx - 1];
        location.href = location.origin + curhref + '#/' + theme;
    }
    window.hashString = location.origin + '/' + curhref + '#/' + theme;
    setSelectList();
}

function processResize(e) {
    if (window.isManualResizeTrigger) {
        window.isManualResizeTrigger = false;
        return;
    }
    var toggle = sidebar.isOpen;
    isMobile = window.matchMedia('(max-width:550px)').matches;
    isTablet = window.matchMedia('(min-width:550px) and (max-width: 850px)').matches;
    isPc = window.matchMedia('(min-width:850px)').matches;
    if (toggle && isMobile) {
        if (!isMobileLeftPaneToggleBtnClicked) { 
            toggleLeftPane();
        }
        isMobileLeftPaneToggleBtnClicked = false;
    }
    if (isMobile) {
        sidebar.contextTo = null;
        sidebar.showBackdrop = true;
        sidebar.closeOnDocumentClick = true;
    } else {
        sidebar.contextTo = document.querySelector('.sb-content ');
        sidebar.showBackdrop = false;
        sidebar.closeOnDocumentClick = false;
    }

    if (resizeManualTrigger) {
        return;
    }
    setLeftPaneHeight();
    var leftPane = ej.base.select('.sb-left-pane');
    var rightPane = ej.base.select('.sb-right-pane');
    var footer = ej.base.select('.sb-footer-left');
    var pref = ej.base.select('#settings-popup');
    if (isTablet || isMobile) {
        contentTab.hideTab(1);
    } else {
        contentTab.hideTab(1, false);
    }
    if (isMobile) {
        ej.base.select('.sb-left-footer-links').appendChild(footer);

        if (isVisible('.sb-mobile-overlay')) {
            removeMobileOverlay();
        }
        if (!pref.parentElement.classList.contains('sb-mobile-preference')) {
            ej.base.select('.sb-mobile-preference').appendChild(pref);
            settingsPopup.show();
        }
        var propPanel = ej.base.select('#control-content .property-section');
        if (propPanel) {
            propPanel.style.setProperty('display', 'block');
            propPanel.style.removeProperty('width');
            var mobileSetting = ej.base.select('.sb-mobile-setting');
            if (mobileSetting) {
                mobileSetting.classList.add('sb-hide');
            }
        }
        if (isVisible('.sb-mobile-overlay')) {
            removeMobileOverlay();
        }
    }
    if (isTablet || isPc) {
        if (leftPane.parentElement.classList.contains('sb-mobile-left-pane')) {
            ej.base.select('.sb-content').appendChild(leftPane);
            ej.base.select('.sb-footer').appendChild(footer);
            if (isVisible('.sb-mobile-overlay')) {
                removeMobileOverlay();
            }
        }
        if (isTablet || (ej.base.Browser.isDevice && isPc)) {
            if (!leftPane.classList.contains('sb-hide')) {
                toggleLeftPane();
            }
            setTimeout(function () {
                if (!rightPane.classList.contains('control-fullview')) {
                    rightPane.classList.add('control-fullview');
                }
            }, 600);
        }
        if (isPc && !ej.base.Browser.isDevice && isVisible('.sb-left-pane')) {
            rightPane.classList.remove('control-fullview');
        }
        if (pref.parentElement.classList.contains('sb-mobile-preference')) {
            ej.base.select('#sb-popup-section').appendChild(pref);
            settingsidebar.hide();
            settingsPopup.hide();
        }
        var propPanel = ej.base.select('#control-content .property-section');
        var isLandscapeTablet = window.matchMedia('max-width: 1024px').matches;
        if (isTablet || isLandscapeTablet) {
            propPanel.style.setProperty('display', 'block');
            propPanel.style.removeProperty('width');
            var mobileSettingTablet = ej.base.select('.sb-mobile-setting');
            if (mobileSettingTablet) {
                mobileSettingTablet.classList.add('sb-hide');
            }
        }
    }
    if (!switcherPopup.element.classList.contains('e-popup-close')) {
        switcherPopup.hide();
    }
}

function resetInput(arg) {
    arg.preventDefault();
    arg.stopPropagation();
    document.getElementById('search-input').value = '';
    document.getElementById('search-input-wrapper').setAttribute('data-value', '');
    searchPopup.hide();
}

function bindEvents() {
    document.getElementById('sb-switcher').addEventListener('click', function (e) {
        e.preventDefault();
        e.stopPropagation();
        sbHeaderClick('changeSampleBrowser');
    });
    ej.base.select('.sb-header-text-right').addEventListener('click', function (e) {
        e.preventDefault();
        e.stopPropagation();
        sbHeaderClick('changeSampleBrowser');
    });
    headerThemeSwitch.addEventListener('click', function (e) {
        e.preventDefault();
        e.stopPropagation();
        sbHeaderClick('changeTheme');
    });
    themeList.addEventListener('click', changeTheme);
    if (headerSdkSwitch) {
        headerSdkSwitch.addEventListener('click', function (e) {
            e.preventDefault();
            e.stopPropagation();
            sbHeaderClick('changeSdk');
        });
        // Wire the mobile-only secondary SDK switcher (lives in its own header bar).
        var headerSdkSwitchMobile = document.getElementById('header-sdk-switcher-mobile');
        if (headerSdkSwitchMobile) {
            headerSdkSwitchMobile.addEventListener('click', function (e) {
                e.preventDefault();
                e.stopPropagation();
                sbHeaderClick('changeSdk');
            });
        }
        var sdkList = document.getElementById('sdklist');
        if (sdkList) {
            sdkList.addEventListener('click', changeSdk);
        }
    }
    document.addEventListener('click', sbHeaderClick.bind(this, 'closePopup'));
    notificationElement.addEventListener('click', function (e) {
        e.preventDefault();
        e.stopPropagation();
        toggleNotification();
    });
    settingElement.addEventListener('click', function (e) {
        e.preventDefault();
        e.stopPropagation();
        sbHeaderClick('toggleSettings');
    });
    searchButton.addEventListener('click', function (e) {
        e.preventDefault();
        e.stopPropagation();
        toggleSearchOverlay();
    });
    document.getElementById('settings-popup').addEventListener('click', function (e) {
        e.preventDefault();
        e.stopPropagation();
    });
    inputele.addEventListener('click', function (e) {
        e.preventDefault();
        e.stopPropagation();
    });
    inputele.addEventListener('keyup', onsearchInputChange);
    setResponsiveElement.addEventListener('click', setMouseOrTouch);
    ej.base.select('#sb-left-back').addEventListener('click', showHideControlTree);
    leftToggle.addEventListener('click', toggleLeftPane);
    ej.base.select('.sb-mobile-overlay').addEventListener('click', toggleMobileOverlay);
    ej.base.select('.sb-header-settings').addEventListener('click', viewMobilePrefPane);
    ej.base.select('.sb-mobile-setting').addEventListener('click', viewMobilePropPane);
    resetSearch.addEventListener('click', resetInput);
    document.getElementById('switch-sb').addEventListener('click', function (e) {
        var target = ej.base.closest(e.target, 'li');
        if (target) {
            var anchor = target.querySelector('a');
            if (anchor) {
                anchor.click();
            }
        }
    });
    ej.base.select('#next-sample').addEventListener('click', onNextPrevButtonClick);
    ej.base.select('#mobile-next-sample').addEventListener('click', onNextPrevButtonClick);
    ej.base.select('#prev-sample').addEventListener('click', onNextPrevButtonClick);
    ej.base.select('#mobile-prev-sample').addEventListener('click', onNextPrevButtonClick);
    window.addEventListener('resize', processResize);
    ej.base.select('.sb-right-pane').addEventListener('click', function () {
        if (isTablet && isLeftPaneOpen()) {
            toggleLeftPane();
        }
    });
    searchEle.addEventListener('click', function (e) {
        var curEle = ej.base.closest(e.target, 'li');
        if (curEle && curEle.classList.contains('e-list-item')) {
            var tcontent = curEle.querySelector('.e-text-content');
            var hashval = '#/' + selectedTheme + '/' + tcontent.getAttribute('data') + '.html';
            inputele.value = '';
            searchPopup.hide();
            searchOverlay.classList.add('e-search-hidden');
            if (location.hash !== hashval) {
                sampleOverlay();
                setSelectList();
            }
        }
    });
}

function onNextPrevButtonClick(arg) {
    sampleOverlay();
    var theme = getThemeName();
    var curSampleUrl = getSamplePath();
    var inx = samplesAr.indexOf(curSampleUrl);
    if (inx !== -1) {
        var prevhref = samplesAr[inx];
        var curhref = (this.id === 'next-sample' || this.id === 'mobile-next-sample') ? samplesAr[inx + 1] : samplesAr[inx - 1];
        location.href = location.origin + getPathName() + curhref + getSdkQueryString() + '#/' + theme;
    }
    window.hashString = location.origin + getPathName() + curhref + getSdkQueryString() + '#/' + theme;
    setSelectList();
}

function copyCode() {
    var copyElem = ej.base.select('#sb-source-tab .e-item.e-active');
    var textArea = ej.base.createElement('textArea');
    textArea.textContent = copyElem.textContent.trim();
    document.body.appendChild(textArea);
    textArea.select();
    document.execCommand('copy');
    ej.base.detach(textArea);
    ej.base.select('.copy-tooltip').ej2_instances[0].close();
}

function setSbLink() {
    var href = location.href;
    var link = href.match(urlRegex);
    var sample = href.match(sampleRegex);
    for (var i = 0, len = sbArray.length; i < len; i++) {
        var sb = sbArray[i];
        var ele = ej.base.select('#' + sb);
        if (sb === 'aspcore') {
            ele.href = 'https://ej2.syncfusion.com/aspnetcore/';
        } else {
            ele.href = ((link) ? ('http://' + link[1] + '/' + (link[3] ? (link[3] + '/') : '')) :
                ('https://ej2.syncfusion.com/')) + (sbObj[sb] ? (sb + '/') : '') + ((sb === 'blazor') ? 'demos/' : 'demos/#/')
                    + (sample ? (sample[1] + (sb !== 'typescript' ? '' : '.html')) : '');
        }
    }

}

function changeMouseOrTouch(str) {
    var activeEle = setResponsiveElement.querySelector('.active');
    if (activeEle) {
        activeEle.classList.remove('active');
    }
    if (str === 'mouse') {
        document.body.classList.remove('e-bigger');
    } else {
        document.body.classList.add('e-bigger');
    }
    setResponsiveElement.querySelector('#' + str).classList.add('active');
}

// check the current themevalue present in themelist based on condition add active class
function addActiveThemePresent(themeList, themeId) {
    const el = themeList?.querySelector(`[id="${themeId}"]`);
    if (el){
 		el.classList.add('active');
	}
}

function loadTheme(theme) {
    var body = document.body;
    if (body.classList.length > 0) {
        for (var themeItem in themes) {
            body.classList.remove(themes[themeItem]);
        }
    }
    if (!isStaging) {
        theme = theme == 'bootstrap5' ? 'bootstrap5.3' : theme == 'bootstrap5-dark' ? 'bootstrap5.3-dark' : theme;
    }
    body.classList.add(theme);
    themeList.querySelector('.active').classList.remove('active');
    /* themeList.querySelector('#' + theme).classList.add('active');*/
    var currentUpdatedTheme = theme.replace("-dark", "");
    addActiveThemePresent(themeList, currentUpdatedTheme);
    var path = location.origin + baseurl;
    var ajax = new ej.base.Ajax(path + 'Content/styles/' + theme + '.css', 'GET', false);
    selectedTheme = theme;
    var rightPaneSB = document.getElementById('right-pane');
    if (rightPaneSB && sidebar.isOpen) {
        rightPaneSB.style.marginLeft = '';
    }
    renderLeftPaneComponents();
    renderSbPopups();
    bindEvents();
    if (isTablet || isMobile) {
        contentTab.hideTab(1);
    }
    sampleArray();
    addRoutes(samplesList);
    if (isTablet && isLeftPaneOpen()) {
        toggleLeftPane();
    }
    elasticlunr.clearStopWords();
    const script = document.createElement('script');
    const jsSuffix = isStaging ? ".min" : "";
    script.src = window.baseurl + 'Scripts/search-index'+jsSuffix +'.js';
    script.type = 'text/javascript';
    script.onload = function () {
        searchInstance = elasticlunr.Index.load(window.searchIndex);
    }
    document.head.appendChild(script);
    hasher.initialized.add(parseHash);
    hasher.changed.add(parseHash);
    hasher.init();
    if (theme == 'fluent2-highcontrast' || theme == 'bootstrap4') {
        var theamswitchDivDisable = document.getElementById("themeSwitchDiv");
        theamswitchDivDisable.style.display = 'none';
    }
}

function toggleMobileOverlay() {
    if (!ej.base.select('.sb-mobile-right-pane').classList.contains('sb-hide')) {
        toggleRightPane();
    }
}

function removeMobileOverlay() {
    ej.base.select('.sb-mobile-overlay').classList.add('sb-hide');
}

function isLeftPaneOpen() {
    return sidebar.isOpen;
}

function isVisible(elem) {
    return !ej.base.select(elem).classList.contains('sb-hide');
}

function setLeftPaneHeight() {
    var leftPane = ej.base.select('.sb-left-pane');
}

function toggleLeftPane() {
    var reverse = sidebar.isOpen;
    var rightPane = ej.base.select('.sb-right-pane');
    ej.base.select('#left-sidebar').classList.remove('sb-hide');
    if (!reverse) {
        leftToggle.classList.add('toggle-active');
        rightPane.classList.add('control-fullview');
    } else {
        leftToggle.classList.remove('toggle-active');
        rightPane.classList.remove('control-fullview');
    }

    if (sidebar) {
        reverse = sidebar.isOpen;
        if (reverse) {
            sidebar.hide();
        } else {
            sidebar.show();
        }
    }
    if (isMobile) {
        isMobileLeftPaneToggleBtnClicked = true;
    }
    else {
        rightPane.classList.toggle('control-fullview');
    }
}

function toggleRightPane() {
    ej.base.select('#right-sidebar').classList.remove('sb-hide');
    var currentUpdatedTheme = selectedTheme.replace("-dark", "");
    themeDropDown.index = themes.indexOf(currentUpdatedTheme);
    if (isMobile) {
        settingsidebar.toggle();
    }
}

function viewMobilePrefPane() {
    ej.base.select('.sb-mobile-prop-pane').classList.add('sb-hide');
    ej.base.select('.sb-mobile-preference').classList.remove('sb-hide');
    toggleRightPane();
    ej.base.select('.e-sidebar-overlay').addEventListener('click', toggleMobileOverlay);
}

function viewMobilePropPane() {
    ej.base.select('.sb-mobile-preference').classList.add('sb-hide');
    ej.base.select('.sb-mobile-prop-pane').classList.remove('sb-hide');
    toggleRightPane();
    ej.base.select('.e-sidebar-overlay').addEventListener('click', toggleMobileOverlay);
}

// Resolves the current SDK from the URL query string. Returns the display name
// (e.g. 'Grid SDK') or null when no SDK filter should be applied.
function resolveCurrentSdkDisplayName() {
    var knownIds = ['Grid', 'Charts', 'Diagram', 'Gantt', 'FileManager', 'Scheduler', 'RichTextEditor'];
    var urlParams = new URLSearchParams(window.location.search);
    var rawSdk = urlParams.get('sdk');
    if (!rawSdk) {
        return null;
    }
    var resolvedSdk = null;
    for (var k = 0; k < knownIds.length; k++) {
        if (knownIds[k].toLowerCase() === rawSdk.toLowerCase()) {
            resolvedSdk = knownIds[k];
            break;
        }
    }
    if (!resolvedSdk || typeof mapSdkIdToDisplayName !== 'function') {
        return null;
    }
    return mapSdkIdToDisplayName(resolvedSdk);
}

function getSampleList() {
    // Store the full unfiltered list for later use (used by the search index,
    // right-pane list view, and component list view when SDK filter is active).
    window._fullSamplesList = window.samplesList;

    // Apply the SDK filter first so both the desktop and mobile branches work
    // with the same component set. The URL query string is the single source of truth.
    var sdkDisplayName = resolveCurrentSdkDisplayName();
    var sourceList = (sdkDisplayName && typeof filterSamplesBySdk === 'function')
        ? filterSamplesBySdk(window.samplesList, sdkDisplayName)
        : window.samplesList;

    if (ej.base.Browser.isDevice) {
        var tempList = ej.base.extend([], sourceList);
        var sampleList = [];
        for (var i = 0; i < tempList.length; i++) {
            var temp = tempList[i];
            if (temp.hideOnDevice == true) {
                if (temp.name == location.href.split('/').splice(-3, 1).join('/')) {
                    var toastObj = new ej.notifications.Toast({
                        position: {
                            X: 'Right'
                        }
                    });
                    toastObj.appendTo('#sb-home');
                    setTimeout(function () {
                        toastObj.show({
                            content: location.href.split('/').splice(-3, 1)[0] + ' component not supported in mobile device'
                        });
                    }, 200);
                    setTimeout(function () {
                        location.href = location.origin + getPathName() + `grid/gridoverview` + getSdkQueryString() + `#/${defaultTheme}`
                    }, 2000)
                }
                continue;
            }
            var data = new ej.data.DataManager(temp.samples);
            temp.samples = data.executeLocal(new ej.data.Query().where('hideOnDevice', 'notEqual', true));
            sampleList = sampleList.concat(temp);
        }
        return sampleList;
    }
    return sourceList;
}

function renderLeftPaneComponents() {
    samplesTreeList = getTreeviewList(samplesList);
    var sampleTreeView = new ej.navigations.TreeView({
        fields: {
            dataSource: samplesTreeList,
            id: 'id',
            parentID: 'pid',
            text: 'name',
            hasChildren: 'hasChild',
            htmlAttributes: 'url'
        },
        nodeClicked: controlSelect,
        nodeTemplate: '<div><span class="tree-text">${name}</span>' +
            '${if(type === "update")}<span class="e-badge sb-badge e-samplestatus ${type} tree tree-badge">Updated</span>' +
            '${else}${if(type)}<span class="e-badge sb-badge e-samplestatus ${type} tree tree-badge">${type}</span>${/if}${/if}</div>'
    }, '#controlTree');
    var controlList = new ej.lists.ListView({
        dataSource: controlSampleData[location.pathname.split('/').slice(-2)[0]] || controlSampleData.Button,
        fields: {
            id: 'uid',
            text: 'name',
            groupBy: 'order',
            htmlAttributes: 'data'
        },
        select: controlSelect,
        template: '<div role="list" class="e-text-content e-icon-wrapper"> <span class="e-list-text" role="listitem">${name}' +
            '</span>${if(type === "update")}<span class="e-badge sb-badge e-samplestatus ${type}">Updated</span>' +
            '${else}${if(type)}<span class="e-badge sb-badge e-samplestatus ${type}">${type}</span>${/if}${/if}' +
            '${if(directory)}<div class="e-icons e-icon-collapsible"></div>${/if}</div>',
        groupTemplate: '${if(items[0]["category"])}<div class="e-text-content">' +
            '<span class="e-list-text">${items[0].category}</span>' +
            '</div>${/if}',
        actionComplete: setSelectList
    }, '#controlList');
}

function getThemeName() {
    return location.hash.split('/')[1] ? location.hash.split('/')[1] : defaultTheme;
}

function getPathName() {
    var samplePath = getSamplePath();
    return location.pathname.replace(samplePath, '');
}

function getSamplePath() {
    return location.pathname.split('/').slice(-2).join('/');
}

function getTreeviewList(list) {
    var id;
    var pid;
    var tempList = [];
    var category = '';
    for (var i = 0; i < list.length; i++) {
        if (category !== list[i].category) {
            category = list[i].category;
            tempList = tempList.concat({
                id: i + 1,
                name: list[i].category,
                hasChild: true,
                expanded: true
            });
            pid = i + 1;
            id = pid;
        }
        id += 1;
        tempList = tempList.concat({
            id: id,
            pid: pid,
            name: list[i].name,
            type: list[i].type,
            url: {
                'data-path': '/' + list[i].directory.toLowerCase() + '/' + list[i].samples[0].url.toLowerCase(),
                'control-name': list[i].directory.toLowerCase(),
            }
        });
        controlSampleData[list[i].directory.toLowerCase()] = getSamples(list[i].samples);
    }
    return tempList;
}

function getSamples(samples) {
    var tempSamples = [];
    for (var i = 0; i < samples.length; i++) {
        tempSamples[i] = samples[i];
        tempSamples[i].data = {
            'sample-name': samples[i].url.toLowerCase(),
            'data-path': '/' + samples[i].dir.toLowerCase() + '/' + samples[i].url.toLowerCase()
        };
    }
    return tempSamples;
}

function controlSelect(arg) {
    var path = (arg.node || arg.item).getAttribute('data-path');
    if (path === null && arg.data) {
        path = arg.data.component.toLowerCase() + '/' + arg.data.url.toLowerCase();
    }
    var curHashCollection = '/' + location.href.split('/').slice(3).join('/');
    var theme = getThemeName();
    if (!arg.item || path.split('/')[1] === curHashCollection.split('/').slice(-2)[1]) {
        controlListRefresh(arg.node || arg.item);
    }
    if (location.pathname.slice(- 1) !== '/' && location.hash !== '#/' + theme) {
        var count;
        if ((location.origin.indexOf('ej2npmci.azurewebsites') !== -1) && location.pathname.split('/').length >= 6) {
            count = 6;
        }
        else if ((location.origin.indexOf('ej2.syncfusion') !== -1) && location.pathname.split('/').length >= 5) {
            count = 5;
        }
        else if ((location.origin.indexOf('localhost') !== -1) && location.pathname.split('/').length >= 3) {
            count = 3;
        }
        location.href = location.origin + location.pathname.split('/').slice(0, count).join('/') + '#/' + theme;
    }
    else {
        if (location.pathname.slice(- 1) === '/') {
            location.href = location.origin + curHashCollection.slice(0, -1);
        }
        else if (path) {
            var splittedUrl = curHashCollection.split("#/")[0].substr(1);
            if (samplesAr.length) {
                var selected_index = samplesAr.indexOf(path.substr(1));
                var current_sample_index = samplesAr.indexOf(splittedUrl);
            }
            if (curHashCollection.indexOf(path) === -1 || (selected_index != current_sample_index)) {
                sampleOverlay();
                if (arg.item && ((isMobile && !ej.base.select('.sb-mobile-left-pane').classList.contains('sb-hide')) ||
                    ((isTablet || (ej.base.Browser.isDevice && isPc)) && isLeftPaneOpen()))) {
                    toggleLeftPane();
                }

                if (arg.data) {
                    var pathName = location.pathname.replace(getSamplePath(), '');
                    if (curHashCollection.split('/')[curHashCollection.split('/').length - 3] != arg.data.dir.toLowerCase()) {
                        var SampleObject = window.samplesList.filter(obj => obj.directory.toLowerCase() === arg.data.dir.toLowerCase());
                        var defaultSample = SampleObject.map(obj => obj.samples[0]);
                        if (arg.item.id.includes("search-popup")) {
                            location.href = location.origin + pathName + arg.data.dir.toLowerCase() + '/' + arg.data.url.toLowerCase() + getSdkQueryString() + '#/' + theme;
                        }
                        else {
                            location.href = location.origin + pathName + arg.data.dir.toLowerCase() + '/' + defaultSample[0].url.toLowerCase() + getSdkQueryString() + '#/' + theme;
                        }                    }
                    else {
                        location.href = location.origin + pathName + arg.data.dir.toLowerCase() + '/' + arg.data.url.toLowerCase() + getSdkQueryString() + '#/' + theme;
                    }
                }
            } else {
                var hashName = location.hash.length ? '' : '#/' + theme
                location.href = location.href + hashName;
            }
        }
    }
}



function controlListRefresh(ele) {
    var samples = controlSampleData[ele.getAttribute('control-name')];
    if (samples) {
        var listView = ej.base.select('#controlList').ej2_instances[0];
        listView.dataSource = samples;
        showHideControlTree();
    }
}

function showHideControlTree() {
    var controlTree = ej.base.select('#controlTree');
    var controlList = ej.base.select('#controlSamples');
    var reverse = ej.base.select('#controlTree').style.display === 'none';
    if (reverse) {
        viewSwitch(controlList, controlTree, reverse);

    } else {
        viewSwitch(controlTree, controlList, reverse);
    }
    const url = location.pathname;
    const pathParts = url.split("/");
    const sampleName = pathParts[pathParts.length - 2];
    const listItem = document.querySelector(`li[control-name="${sampleName}"]`);
    if (listItem) {
     	listItem.classList.add('e-active');
    }
    const selectedDiv = document.querySelector('.e-active');
    if (selectedDiv) {
     	selectedDiv.scrollIntoView({
        block: 'center'
    	});
     }
}

function viewSwitch(from, to, reverse) {
    var anim = new ej.base.Animation({
        duration: 500,
        timingFunction: 'ease'
    });
    var controlTree = ej.base.select('#controlTree');
    var controlList = ej.base.select('#controlList');
    controlTree.style.overflowY = 'hidden';
    controlList.classList.remove('e-view');
    controlList.classList.remove('sb-control-list-top');
    controlList.classList.add('sb-adjust-juggle');
    to.style.display = '';
    anim.animate(from, {
        name: reverse ? 'SlideRightOut' : 'SlideLeftOut',
        end: function () {
            controlTree.style.overflowY = 'auto';
            from.style.display = 'none';
            controlList.classList.add('e-view');
            controlList.classList.add('sb-control-list-top');
            controlList.classList.remove('sb-adjust-juggle');
        }
    });
    anim.animate(to, {
        name: reverse ? 'SlideLeftIn' : 'SlideRightIn'
    });
}

function setSelectList() {
    var hString = location.pathname;
    var hash = hString.split('/');
    var list = ej.base.select('#controlList').ej2_instances[0];
    var sampleName = hash.slice(-2)[1];
    var selectSample = ej.base.select('[sample-name="' + sampleName.replace('#', '') + '"]') || ej.base.select('[sample-name="' + list.localData[0].url.toLowerCase()
    + '"]');
    if (selectSample) {
        if (ej.base.select('#controlTree').style.display !== 'none') {
            showHideControlTree();
        }
        list.selectItem(selectSample);
    }
    else {
        showHideControlTree();
        list.selectItem(ej.base.select('[sample-name="line"]'));
    }
}

function toggleButtonState(id, state) {
    var ele = document.getElementById(id);
    var mobileEle = document.getElementById('mobile-' + id);
    ele.disabled = state;
    mobileEle.disabled = state;
    if (state) {
        mobileEle.classList.add('e-disabled');
        ele.classList.add('e-disabled');
    } else {
        mobileEle.classList.remove('e-disabled');
        ele.classList.remove('e-disabled');
    }
}

function setPropertySectionHeight() {
    if (!isTablet && !isMobile) {
        var propertypane = ej.base.select('.property-section');
        var ele = document.querySelector('.control-section');
        if (ele && propertypane) {
            ele.classList.add('sb-property-border');
        } else {
            ele.classList.remove('sb-property-border');
        }
    }
}

function sampleArray() {
    for (var node in samplesList) {
        var dataManager = new ej.data.DataManager(samplesList[node].samples);
        var samples = dataManager.executeLocal(new ej.data.Query().sortBy('order', 'ascending'));
        for (var sample in samples) {
            var selectedTheme = location.hash.split('/')[1] ? location.hash.split('/')[1] : defaultTheme;
            var control = samplesList[node].directory.toLowerCase();
            var sampleUrl = samples[sample].url.toLowerCase();
            var loc = control + '/' + sampleUrl;
            samplesAr.push(loc);
        }
    }
}

function addRoutes(samplesList) {
    // Check if the current sample path exists in the filtered samplesList
    var currentPath = getSamplePath();
    var currentSampleExists = false;

    var loop1 = function (node) {
		
        var dataManager = new ej.data.DataManager(node.samples);
        var samples = dataManager.executeLocal(new ej.data.Query().sortBy('order', 'ascending'));
        var loop2 = function (subNode) {
            var control = node.directory.toLowerCase();
            var sample = subNode.url.toLowerCase();
            samplePath = samplePath.concat(control + '/' + sample);
            var sampleName = node.name + ' / ' + ((node.name !== subNode.category) ?
                (subNode.category + ' / ') : '') + subNode.url.toLowerCase();
            var selectedTheme = location.hash.split('/')[1] ? location.hash.split('/')[1] : defaultTheme;
            var urlString = control + '/' + sample;
            if (getSamplePath() === urlString) {
                currentSampleExists = true;
                var dataSourceLoad = document.getElementById(node.dataSourcePath);
                if (node.dataSourcePath && !dataSourceLoad) {
                    var dataAjax = new ej.base.Ajax(node.dataSourcePath, 'GET', true);
                    dataAjax.send().then(function (result) {
                        var ele = ej.base.createElement('script', {
                            id: node.dataSourcePath,
                            innerHTML: result
                        });
                        document.getElementsByTagName('head')[0].appendChild(ele);
                        onDataSourceLoad(node, subNode, control, sample, sampleName);
                    });
                } else {
                    onDataSourceLoad(node, subNode, control, sample, sampleName);
                }
            }
        };
        for (var i = 0; i < samples.length; i++) {
            var subNode = samples[i];
            loop2(subNode);
        }
    };
    for (var i = 0; i < samplesList.length; i++) {
        var node = samplesList[i];
        loop1(node);
    }

    // If the current sample doesn't exist in the filtered list, redirect to the first available sample.
    // This handles SDK switches where the previous sample is not part of the new SDK.
    if (!currentSampleExists && samplesList.length > 0) {
        var firstNode = samplesList[0];
        var firstDataManager = new ej.data.DataManager(firstNode.samples);
        var firstSamples = firstDataManager.executeLocal(new ej.data.Query().sortBy('order', 'ascending'));
        if (firstSamples.length > 0) {
            var firstControl = firstNode.directory.toLowerCase();
            var firstSample = firstSamples[0].url.toLowerCase();
            var currentTheme = location.hash.split('/')[1] || defaultTheme;
            // Preserve the sdk query string if present
            var sdkQuery = location.search || '';
            var newUrl = location.origin + location.pathname.split('/').slice(0, -2).join('/') + '/' + firstControl + '/' + firstSample + sdkQuery + '#/' + currentTheme;
            location.replace(newUrl);
        }
    }
}

function onDataSourceLoad(node, subNode, control, sample, sampleName) {
    var controlID = node.uid;
    var sampleID = subNode.uid;
    setSbLink();
    var ajaxCS = new ej.base.Ajax((window.hasher.getBaseURL().includes('ej2.syncfusion.com') ? 'https://aspnetmvc.syncfusion.com/aspnetmvc/' : baseurl) + 'Controllers/' + subNode.dir.toLowerCase() + '/' + subNode.url.toLowerCase() + 'Controller.cs', 'GET', false);
    var ajaxCSHTML = new ej.base.Ajax((window.hasher.getBaseURL().includes('ej2.syncfusion.com') ? 'https://aspnetmvc.syncfusion.com/aspnetmvc/' : baseurl) + 'Home/GetHtml?path=Views/' + subNode.dir.toLowerCase() + '/' + subNode.url.toLowerCase() + '.cshtml', 'GET', false);
    var add = [ajaxCSHTML, ajaxCS];
    var cs = subNode.url.toLowerCase() + 'controller.cs';
    var cshtml = subNode.url.toLowerCase() + '.cshtml';
    var name = [cshtml, cs];
    //var p2 = loadScriptfile('src/' + control + '/' + sample + '.js');
    //var ajaxJs = new ej.base.Ajax('src/' + control + '/' + sample + '.js', 'GET', true);
    //sampleNameElement.innerHTML = node.name;
    sourceTab.selectedItem = 0;
    contentTab.selectedItem = 0;
    breadCrumbComponent.innerHTML = node.name;
    if (node.name !== subNode.category) {
        breadCrumbSubCategory.innerHTML = subNode.category;
        breadCrumbSubCategory.style.display = '';
        breadCrumSeperator.style.display = '';
    } else {
        breadCrumbSubCategory.style.display = 'none';
        breadCrumSeperator.style.display = 'none';
    }
    if (getSamplePath() == subNode.dir.toLowerCase() + '/' + subNode.url.toLowerCase()) {
        breadCrumbSample.innerHTML = subNode.name;
    }
    var ext, ajaxJS;
    if (subNode.sourceFiles) {
        add = [];
        name = [];
        for (var i = 0; i < subNode.sourceFiles.length; i++) {
            var srcPath = (subNode.sourceFiles[i].path).includes('.cshtml') && window.hasher.getBaseURL().includes('ej2.syncfusion.com') ?
                subNode.sourceFiles[i].path.replace('..', 'https://aspnetmvc.syncfusion.com/aspnetmvc') : subNode.sourceFiles[i].path;
            var ajaxAdd = new ej.base.Ajax(srcPath, 'GET', false);
            add.push(ajaxAdd);
            var optional = subNode.sourceFiles[i].displayName;
            name.push(optional);
        }
    }
    var subfile = 0;
    for (var file = 0; file < add.length; file++) {
        add[file].send().then(function (value) {
            var content;
            if (/html/g.test(name[subfile])) {
                value = value.replace(/@section (ActionDescription|Title|Description|Meta|Header){[^}]*}/g, '').trim();
                value = value.replace(/([\r\n]+){3,}/g, '\n');
                content = value.replace(/&/g, '&amp;')
                    .replace(/"/g, '&quot;').replace(/</g, '&lt;').replace(/>/g, '&gt;');
            } else {
                content = value.replace(/&/g, '&amp;')
                    .replace(/"/g, '&quot;').replace(/</g, '&lt;').replace(/>/g, '&gt;');
            }
            items.push({
                header: {
                    text: name[subfile]
                },
                data: content,
                content: name[subfile]
            })
            subfile++;
        });
    }
    ArrayItem = items;
    currentControlID = controlID;
    currentSampleID = sampleID;
    currentControl = node.directory.toLowerCase();
    var curIndex = samplesAr.indexOf(getSamplePath());
    var samLength = samplesAr.length - 1;
    if (curIndex === samLength) {
        toggleButtonState('next-sample', true);
    } else {
        toggleButtonState('next-sample', false);
    }
    if (curIndex === 0) {
        toggleButtonState('prev-sample', true);
    } else {
        toggleButtonState('prev-sample', false);
    }
    ej.base.select('#control-content').classList.remove('error-content');

    renderPropertyPane('#property');
    window.navigateSample();
    isExternalNavigation = defaultTree = false;
    setPropertySectionHeight();
    removeOverlay();
    var mobilePropPane = ej.base.select('.sb-mobile-prop-pane .property-section');
    if (mobilePropPane) {
        ej.base.detach(mobilePropPane);
    }
    var propPanel = ej.base.select('#control-content .property-section');
    var isLandscapeTablet = window.matchMedia('(max-width: 1024px)').matches;
    if (isLandscapeTablet) {
        if (propPanel) {
            propPanel.style.setProperty('display', 'block');
            propPanel.style.removeProperty('width');
            var mobileSetting = ej.base.select('.sb-mobile-setting');
            if (mobileSetting) {
                mobileSetting.classList.add('sb-hide');
            }
        }
    }
}
function initializeGTM() {
    setTimeout(function () {
        (function (w, d, s, l, i) {
            w[l] = w[l] || []; w[l].push({
                'gtm.start':
                    new Date().getTime(), event: 'gtm.js'
            }); var f = d.getElementsByTagName(s)[0],
                j = d.createElement(s), dl = l != 'dataLayer' ? '&l=' + l : ''; j.async = true; j.src =
                    'https://www.googletagmanager.com/gtm.js?id=' + i + dl; f.parentNode.insertBefore(j, f);
        })(window, document, 'script', 'dataLayer', 'GTM-P3WXFWCW');
        
        (function (w, d, s, l, i) {
            w[l] = w[l] || []; w[l].push({
                'gtm.start':
                    new Date().getTime(), event: 'gtm.js'
            }); var f = d.getElementsByTagName(s)[0],
                j = d.createElement(s), dl = l != 'dataLayer' ? '&l=' + l : ''; j.async = true; j.src =
                    'https://www.googletagmanager.com/gtm.js?id=' + i + dl; f.parentNode.insertBefore(j, f);
        })(window, document, 'script', 'dataLayer', 'GTM-W8WD8WN');
    }, 500);
}

function loadStylesheet(href) {
    const link = document.createElement("link");
    link.rel = "stylesheet";
    link.href = href;
    document.head.appendChild(link);
}
function loadScript(src, integrity) {
    const script = document.createElement("script");
    script.src = src;
    script.type = "text/javascript";
    if (integrity) {
        script.crossOrigin = "anonymous";
        script.integrity = integrity;
    }
    document.head.appendChild(script);
}
function removeOverlay() {
    const cssSuffix = isStaging ? ".min" : "";
    loadStylesheet(window.baseurl + "Content/styles/highlight" + cssSuffix + ".css");
    loadStylesheet(window.baseurl + "Content/styles/roboto" + cssSuffix + ".css");
     if (window.location.href.includes("richtexteditor/onlinehtmleditor") || window.location.href.includes("richtexteditor/overview") || window.location.href.includes("richtexteditor/enterkey")) {
        loadStylesheet(window.baseurl + "Content/RichTextEditor/codemirror " + cssSuffix +".css");
        const scripts = [
            {
                src: "https://cdnjs.cloudflare.com/ajax/libs/codemirror/5.3.0/mode/css/css.js",
                integrity: "sha384-bx2UEHmkahlrzAHJQxatI4mjOrSrRKEmueT3DZSS3OY392BXvcqXcgUqWnse30VV"
            },
            {
                src: "https://cdnjs.cloudflare.com/ajax/libs/codemirror/5.3.0/mode/xml/xml.js",
                integrity: "sha384-83KFdJ/lJGxIW+p+cbX3MI8vwU/s+pQbv42uek9/nt283oRLzP8YJ2J7uSBgoRuw"
            },
            {
                src: "https://cdnjs.cloudflare.com/ajax/libs/codemirror/5.3.0/mode/htmlmixed/htmlmixed.js",
                integrity: "sha384-yUJOFmuHndKeGdERelLizdhzB2ghbvBSFWMcE7z3t5kOERXoOwvNQhYTAvjiZV80"
            }
        ];
        scripts.forEach(({ src, integrity }) => {
            loadScript(src, integrity);
        });
     }
    setTimeout(function () {
        contentTab.hideTab(1);
        contentTab.hideTab(1, false);
        document.body.setAttribute('aria-busy', 'false');
        sbContentOverlay.classList.add('sb-hide');
        sbRightPane.classList.remove('sb-right-pane-overlay');
        sbHeader.classList.remove('sb-right-pane-overlay');
        mobNavOverlay(false);
        if (!sbBodyOverlay.classList.contains('sb-hide')) {
            sbBodyOverlay.classList.add('sb-hide');
			initializeGTM();
        }
        if (!isMobile) {
            sbRightPane.scrollTop = 0;
        } else {
            sbRightPane.scrollTop = 74;
        }
    }, 200)
}

function sampleOverlay() {
    document.body.setAttribute('aria-busy', 'true');
    sbHeader.classList.add('sb-right-pane-overlay');
    sbRightPane.classList.add('sb-right-pane-overlay');
    mobNavOverlay(true);
    sbContentOverlay.classList.remove('sb-hide');
}

function overlay() {
    sbHeader.classList.add('sb-right-pane-overlay');
    sbBodyOverlay.classList.remove('sb-hide');
}

function mobNavOverlay(isOverlay) {
    if (ej.base.isDevice) {
        var mobileFoorter = ej.base.select('.sb-mobilefooter');
        if (isOverlay) {
            mobileFoorter.classList.add('sb-right-pane-overlay');
        } else {
            mobileFoorter.classList.remove('sb-right-pane-overlay');
        }
    }
}

function parseHash(newHash, oldHash) {
    var newTheme = newHash.split('/')[0];
    if (newTheme !== selectedTheme && themes.indexOf(newTheme) !== -1) {
           location.reload();
           crossroads.parse(newHash);
        }
        crossroads.parse(newHash);
    
}

function renderPropertyPane(ele) {
    var contentEle = ej.base.select('#control-content');
    var elem = contentEle.querySelector(ele);
    var title;
    if (!elem) {
        return;
    }
    title = elem.getAttribute('title');
    var parentEle = elem.parentElement;
    elem = ej.base.detach(elem);
    elem.classList.add('property-panel-table');
    var parentPane = ej.base.createElement('div', {
        className: 'property-panel-section',
        innerHTML: "<div class=\"property-panel-header\">" + title + "</div><div class=\"property-panel-content\"></div>"
    });
    parentPane.children[1].appendChild(elem);
    parentEle.appendChild(parentPane);
}


function loadJSON() {
    var storedSwitch = localStorage.getItem('ej2-switch');
    var switchText;
    var switchlocalization = sessionStorage.getItem('ej2-culture') || 'en';
    if (window.screen.width < 768) {
        switchText = 'touch';
    } else if (storedSwitch) {
        switchText = storedSwitch;
    } else {
        switchText = 'mouse';
    }
    setLeftPaneHeight();
    if (isMobile) {
        ej.base.select('.sb-left-footer-links').appendChild(ej.base.select('.sb-footer-left'));
        leftToggle.classList.remove('toggle-active');
    }
    /**
     * Tab View
     */
    if (isTablet || (ej.base.Browser.isDevice && isPc)) {
        leftToggle.classList.remove('toggle-active');
        ej.base.select('.sb-right-pane').classList.add('control-fullview');
    }

    overlay();
    changeMouseOrTouch(switchText);
    // localStorage.removeItem('ej2-switch');
    ej.base.enableRipple(selectedTheme?.indexOf('material3') !== -1 || !selectedTheme);
    loadTheme(selectedTheme);
    loadCulture(switchlocalization);
}
loadJSON();
// Bootstrap the SDK popup state from the URL (must run after DOM is ready
// and after the SDK popup has been rendered by loadTheme -> renderSbPopups).
setTimeout(function () { getSdkSwitcher(); }, 0);

// Get the button element
var button = document.getElementById('buttoncolor');

// Attach click event listener to the button
button.addEventListener('click', function () {
    // Call the navigateToPage function when the button is clicked
    navigateToPage();
});
var updatedURL;
var currentURL;
currentURL = window.location.href;

function updateThemeURL() {
    var current_URL = window.location.href;
    var updatedURL = current_URL;

    if (current_URL.includes("#/")) {
        var urlParts = current_URL.split("#/");
        var baseUrl = urlParts[0];
        var hashValue = urlParts[1];
        if (hashValue.includes("-dark")) {
            // Remove "-dark" from the hash 
            hashValue = hashValue.replace("-dark", "");
        } else {
            // Append "-dark" to the hash
            hashValue = hashValue + "-dark";
        }
        updatedURL = baseUrl + "#/" + hashValue;
    } else {
        //console.log("No hash found in the URL");
    }
    // Return the updated URL
    return updatedURL;
}

function navigateToPage() {
    var updatedURL = updateThemeURL();
    localStorage.setItem('PreviousURL', updatedURL);
    window.location.href = updatedURL;
    location.reload();
}

function ScrollToSelected() {
    const selectedDiv = document.querySelector('.sb-left-pane .e-listview .e-list-item.e-active');
    if (selectedDiv) {
        selectedDiv.scrollIntoView({
            block: 'center'
        });
    }
}

document.addEventListener("DOMContentLoaded", function() { setTimeout(function() { ScrollToSelected(); }, 500); });
window.addEventListener('resize', ScrollToSelected);

document.addEventListener('keydown', function (e) {
    if (e.keyCode === 27) {
        var preference_popup = document.querySelector(".sb-setting-popup");
        var theme_popup = document.querySelector(".sb-theme-popup");
        var sb_switcher_popup = document.querySelector(".sb-switch-popup");
        if (!preference_popup.classList.contains("e-popup-close")) {
            preference_popup.classList.add("e-popup-close");
        }
        if (!theme_popup.classList.contains("e-popup-close")) {
            theme_popup.classList.add("e-popup-close");
        }
        if (!sb_switcher_popup.classList.contains("e-popup-close")) {
            sb_switcher_popup.classList.add("e-popup-close");
        }
    }
});

window.addEventListener('hashchange', () => {
    if (isMobile) {
        var hash = window.location.hash;
        var themeValue = hash.split('/').pop();
        if (!isStaging) {
            themeValue = themeValue === 'bootstrap5-dark' ? 'bootstrap5.3-dark' : themeValue;
        }
        if (themeValue.includes('-dark') && themes.indexOf(themeValue.replace('-dark', '')) !== -1) {
            localStorage.setItem('currentTheme', themeValue);
            location.reload();
        }
    }
});

window.addEventListener('load', function () {
    // Get the meta description content
    const metaDescription = document.querySelector('meta[name="description"]')?.getAttribute('content');
    // Get the page title
    const pageTitle = document.title;
    setOpenGraphTags({
        'og:title': pageTitle,
        'og:description': metaDescription,
        'og:url': window.location.href,
        'og:image': 'https://cdn.syncfusion.com/content/images/company-logos/Syncfusion_Logo_Image.png',
        'og:type': 'website'
    });
});
//Appends Open Graph meta tags for link previews on social media platforms like Facebook and LinkedIn.These tags define how the page title, description, URL, and image are displayed when shared.
function setOpenGraphTags(ogData) {
    const head = document.getElementsByTagName('head')[0];
    const createOrUpdateMeta = (property, content) => {
        let meta = document.querySelector(`meta[property='${property}']`);
        if (!meta) {
            meta = document.createElement('meta');
            meta.setAttribute('property', property);
            head.appendChild(meta);
        }
        meta.setAttribute('content', content);
    };
    for (const [property, content] of Object.entries(ogData)) {
        createOrUpdateMeta(property, content);
    }
}

const themepopup = document.querySelector('#theme-switcher-popup');
const settingspopup = document.querySelector('#settings-popup');
const sdkPopup = document.querySelector('#sdk-switcher-popup');

// Function to close the popup
function closePopup() {
    const popups = [themepopup, settingspopup, sdkPopup];
    popups.forEach(popup => {
        if (popup?.classList.contains('e-popup-open')) {
            popup.classList.remove('e-popup-open');
            popup.classList.add('e-popup-close');
        }
    });
}

// Add event listener for window resize
window.addEventListener('resize', closePopup);

// Keyboard navigation for the SDK switcher popup. Handles ArrowUp / ArrowDown
// (move focus through visible items), Enter (activate the focused item or
// toggle the popup when focus is on a trigger button) and Escape (close the
// popup). Trigger buttons (desktop + mobile) can be opened with Enter when
// the popup is closed, and the popup is closed (not re-selected) when Enter
// is pressed on a trigger while the popup is already open.
document.addEventListener('keydown', function (e) {
    var popup = document.getElementById('sdk-switcher-popup');
    if (!popup) { return; }
    var isOpen = popup.classList.contains('e-popup-open') ||
        (popup.style && popup.style.display !== 'none' && popup.offsetParent !== null);
    var key = e.key;
    if (key === 'ArrowDown' || key === 'ArrowUp' || key === 'Enter' || key === 'Escape') {
        var onTrigger = e.target && (
            e.target.id === 'header-sdk-switcher' ||
            e.target.id === 'header-sdk-switcher-mobile' ||
            (typeof e.target.closest === 'function' &&
                (e.target.closest('#header-sdk-switcher') || e.target.closest('#header-sdk-switcher-mobile')))
        );
        // Enter on the trigger button toggles the popup the same way a
        // mouse click does. When the popup is already open, this closes
        // it (instead of re-selecting the active SDK item).
        if (key === 'Enter' && onTrigger) {
            e.preventDefault();
            if (isOpen) {
                sbHeaderClick('changeSdk');
                // Restore focus to whichever trigger was used.
                if (e.target.id === 'header-sdk-switcher-mobile') {
                    var mobileTrigger = document.getElementById('header-sdk-switcher-mobile');
                    if (mobileTrigger) { mobileTrigger.focus(); }
                } else {
                    if (headerSdkSwitch && typeof headerSdkSwitch.focus === 'function') {
                        headerSdkSwitch.focus();
                    }
                }
            } else {
                e.target.click();
            }
            return;
        }
        if (!isOpen) { return; }
        handleSdkKeyboard(e);
    }
});

// Toggle open/close
function toggleNotification() {
    sbHeaderClick('closePopup', true);
    if (!searchOverlay.classList.contains('sb-hide')) {
        toggleSearchOverlay();
    }
    var popup = document.querySelector('.sb-notification-popup');
    var overlay = document.querySelector('.sb-notification-overlay');
    if (!popup || !overlay) return;
    var isHidden = popup.classList.contains('sb-hide');
    if (isHidden) {
        buildNotifications(); // build on open
        popup.classList.remove('sb-hide');
        popup.classList.add('active');
        overlay.classList.remove('sf-hidden');
    } else {
        popup.classList.add('sb-hide');
        popup.classList.remove('active');
        overlay.classList.add('sf-hidden');
    }
}
function hideNotification(e) {
    var popup = document.querySelector('.sb-notification-popup');
    var overlay = document.querySelector('.sb-notification-overlay');
    if (!popup || !overlay) return;
    popup.classList.add('sb-hide');
    popup.classList.remove('active');
    overlay.classList.add('sf-hidden');
}
function notificationKeyDown(e) {
    if (e.key === 'Escape') hideNotification(e);
    if (e.key === 'Enter') toggleNotification();
}
  // Build notifications from window.samplesList
function buildNotifications() {
    var container = document.getElementById('notificationBody');
    if (!container) return;
    var data = (window.samplesList || []);
    var compUpdates = data.filter(function(component){
        var notificationType = (component.type || '').toString().toLowerCase();
        var notificationDescription = component.notificationDescription && String(component.notificationDescription).trim() !== '';
        return (notificationType === 'new' || notificationType === 'update') && notificationDescription;
    });
    var sampleUpdates = [];
    data.forEach(function (component) {
        var updates = (component.samples || []).filter(function(sample) {
            var notificationType = (sample.type || '').toString().toLowerCase();
            var notificationDescription = sample.notificationDescription && String(sample.notificationDescription).trim() !== '';
            return (notificationType === 'new' || notificationType === 'update') && notificationDescription;
        });
        if (updates.length) {
            sampleUpdates.push({ name: component.name, directory: component.directory, samples: updates });
        }
    });
    var html = '';
    // Sample-level updates
    var hadAnySample = false;
    sampleUpdates.forEach(function(group) {
        hadAnySample = true;
        var compPath = ('/' + (group.directory || '')).toLowerCase();
        var samplesHtml = '';
        
        group.samples.forEach(function(sample) {
        // Creates sampleUrl for View Demo in notification popup for each sample
        var pathname = window.location.pathname;
        const parts = pathname.split('/').filter(Boolean);
        parts.splice(-2, 2);
        let result = ''
        if (parts != 0) { result = '/' + parts.join('/'); }
        var sampleUrl = ((result)+ '/' + (group.directory || '') + '/' + (sample.url || '')).toLowerCase();
        
        var listClass = 'sb-notification-list list-type-none';
        var notes = sample.notificationDescription ? sample.notificationDescription : [labelForType(sample.type)];

        samplesHtml += `
            <div class="sb-notification-list-container">
            <div class="sb-notification-sample">
                ${escapeHtml(sample.name || 'Sample')} -
                <span class="sb-Notification-link-label">
                <a href="${sampleUrl}" target="_blank" aria-label="View Demo">View Demo</a>
                </span>
            </div>
            <ul class="${listClass}">
                <li>${notes}</li>
            </ul>
            </div>`;
        });
        html += `
        <div class="sb-notification-content-container">
            <div class="sb-notification-content">
            <div class="sb-notification-category">
                <a href="${compPath}" target="_blank" aria-label="Component name">
                ${escapeHtml(group.name || 'Component')}
                </a>
            </div>
            ${samplesHtml}
            </div>
        </div>`;
    });
    if (!compUpdates.length && !hadAnySample) {
        html = '<span class="sb-notifiction-Update">No new updates available.</span>';
    }
    container.innerHTML = html;
}
  // Helpers
function labelForType(t) {
    var v = (t || '').toString().toLowerCase();
    if (v === 'new') return 'New';
    if (v === 'update' || v === 'updated') return 'Updated';
    return 'Change';
}
function escapeHtml(str) {
    return (str || '').toString()
        .replace(/&/g,'&amp;').replace(/</g,'&lt;')
        .replace(/>/g,'&gt;').replace(/"/g,'&quot;')
        .replace(/'/g,'&#39;');
}
function initializeNotificationSystem() {
    const STORAGE_KEY = 'sbNotificationSeen';
    const VERSION_KEY = 'sbNotificationVersion';
    const CURRENT_VERSION = '35.1.37'; // Update this with each release
    function getDot() {
        return document.querySelector('.sb-notification-btn .e-badge-dot');
    }
    function removeDot() {
        const dot = getDot();
        if (dot && dot.parentElement) {
            dot.parentElement.removeChild(dot);
        }
    }
    function markSeen() {
        if (localStorage.getItem(STORAGE_KEY) === '1') return;
        localStorage.setItem(STORAGE_KEY, '1');
        removeDot();
    }
    function checkVersionUpdate() {
        const storedVersion = localStorage.getItem(VERSION_KEY);
        
        // If version changed, reset notification and show dot
        if (storedVersion !== CURRENT_VERSION) {
            localStorage.setItem(VERSION_KEY, CURRENT_VERSION);
            localStorage.removeItem(STORAGE_KEY); // Reset seen status
            return true; // New version detected
        }
        return false; // Same version
    }
    function handleStorageChange(e) {
        // This event fires in OTHER windows when localStorage changes
        if (e.key === STORAGE_KEY && e.newValue === '1') {
            removeDot();
        }
        if (e.key === VERSION_KEY && e.newValue !== CURRENT_VERSION) {
            checkVersionUpdate();
        }
    }
    function wire() {
        // Check for version update first
        const isNewVersion = checkVersionUpdate();
        // If already seen before and no new version, remove dot immediately and return.
        if (localStorage.getItem(STORAGE_KEY) === '1' && !isNewVersion) {
            removeDot();
            return;
        }
        else {
            var element = document.querySelector('.sb-notification-btn .e-badge-dot');
            if (element) {
                element.classList.remove('e-badge-showdot');
            }
        }
        const overlay = document.querySelector('.sb-notification-overlay');
        const popup = document.querySelector('.sb-notification-popup');
        const clearIcon = document.querySelector('.sb-notification-clear-icon');
        // Listen for storage changes from other windows
        window.addEventListener('storage', handleStorageChange);
        // When the overlay is clicked, mark as seen.
        if (overlay) {
            overlay.addEventListener('click', function () {
                markSeen();
            }, true);
        }
        // When the "clear" icon is clicked, mark as seen.
        if (clearIcon) {
            clearIcon.addEventListener('click', function () {
                markSeen();
            }, true);
        }
        // If the popup is closed via Esc key, mark as seen.
        document.addEventListener('keydown', function (e) {
            if ((e.key === 'Escape' || e.key === 'Esc') && overlay && !overlay.classList.contains('sf-hidden')) {
                markSeen();
            }
        });
    }
    if (document.readyState === 'loading') {
        document.addEventListener('DOMContentLoaded', wire);
    } else {
        wire();
    }
}
// Initialize the notification system when the page is ready
if (document.readyState === 'loading') {
    document.addEventListener('DOMContentLoaded', initializeNotificationSystem);
} else {
    initializeNotificationSystem();
}

window.addEventListener('load', function () {
    // Initialize controlSampleData from the full unfiltered list so the
    // component list view always has data even when the SDK filter is active.
    if (typeof initializeAllControlSampleData === 'function') {
        initializeAllControlSampleData();
    }
    // Get the meta description content
    const metaDescription = document.querySelector('meta[name="description"]')?.getAttribute('content');
    // Get the page title
    const pageTitle = document.title;
    var pageUrl = window.location.href;
    const imageUrl = 'https://cdn.syncfusion.com/content/images/company-logos/Syncfusion_Logo_Image.png';


    // Open Graph Tags
    setMetaTags({
        'og:title': pageTitle,
        'og:description': metaDescription,
        'og:url': pageUrl,
        'og:image': imageUrl,
        'og:type': 'website'
    }, 'property');
    
    // Twitter Tags
    setMetaTags({
        'twitter:account_id': '41152441',
        'twitter:url': pageUrl,
        'twitter:title': pageTitle,
        'twitter:card': 'summary',
        'twitter:description': metaDescription,
        'twitter:image': imageUrl
    }, 'name');

    // JSON-LD Structured Data (WebApplication + BreadcrumbList)
    (function () {
        var origin = window.location.origin;
        var pathParts = window.location.pathname.split('/').filter(function (p) { return p; });
        var breadcrumbItems = [];
        // Home entry
        breadcrumbItems.push({
            "@type": "ListItem",
            "position": 1,
            "name": "Home",
            "item": origin + '/'
        });
        for (var i = 0; i < pathParts.length; i++) {
            var name = decodeURIComponent(pathParts[i]).replace(/[-_]/g, ' ');
            name = name.charAt(0).toUpperCase() + name.slice(1);
            breadcrumbItems.push({
                "@type": "ListItem",
                "position": i + 2,
                "name": name,
                "item": origin + '/' + pathParts.slice(0, i + 1).join('/') + '/'
            });
        }

        setJsonLd({
            "@context": "https://schema.org",
            "@graph": [
                {
                    "@type": "WebApplication",
                    "@id": origin + '/',
                    "name": pageTitle || document.title || 'Syncfusion Samples',
                    "headline": pageTitle || document.title,
                    "description": metaDescription || document.querySelector('meta[name="description"]')?.getAttribute('content') || '',
                    "applicationCategory": "DeveloperApplication",
                    "operatingSystem": "Web",
                    "url": pageUrl,
                    "publisher": {
                        "@type": "Organization",
                        "name": "Syncfusion",
                        "logo": {
                            "@type": "ImageObject",
                            "url": "https://www.syncfusion.com/favicon.ico"
                        }
                    }
                },
                {
                    "@type": "BreadcrumbList",
                    "@id": pageUrl + '#breadcrumb',
                    "itemListElement": breadcrumbItems
                }
            ]
        });
    })();
});


//Appends Open Graph meta tags for link previews on social media platforms like Facebook and LinkedIn.These tags define how the page title, description, URL, and image are displayed when shared.

function setMetaTags(tags, attrType) {
    const head = document.getElementsByTagName('head')[0];
    for (const [key, value] of Object.entries(tags)) {
        let meta = document.querySelector(`meta[${attrType}='${key}']`);
        if (!meta) {
            meta = document.createElement('meta');
            meta.setAttribute(attrType, key);
            head.appendChild(meta);
        }
        meta.setAttribute('content', value);
    }
}


function setJsonLd(data) {
    let script = document.querySelector('script[type="application/ld+json"]');
    if (!script) {
        script = document.createElement('script');
        script.type = 'application/ld+json';
        document.head.appendChild(script);
    }
    script.textContent = JSON.stringify(data);
}
/*property panel section */
function ensureToggleButton() {
    if (window.innerWidth <= 1024) {
        return null;
    }
    var propertySection = document.querySelector('.property-section');
    var controlSection = document.querySelector('.control-section');
    var existing = document.querySelector('.sb-prop-panel-toggle-btn');
    var contentRoot = document.getElementById('control-content');

    if (!propertySection || !contentRoot) {        
        return null;
    }

    if (existing) {
        return existing;
    }
    var btn = document.createElement('div');
    btn.className = 'sb-prop-panel-toggle-btn';
    btn.setAttribute('role', 'button');
    btn.setAttribute('tabindex', '0');
    btn.setAttribute('aria-label', 'toggle property panel');
    btn.setAttribute('title', 'Toggle Property Panel');
    var icon = document.createElement('span');
    icon.className = 'e-icons e-settings';
    btn.appendChild(icon);

    let isOpen = false;

    propertySection.classList.remove('add-transition');
    controlSection.classList.remove('add-transition');
    controlSection.classList.remove('sb-property-no-border');
    controlSection.classList.add('sb-property-border');
    propertySection.style.setProperty("display", "none");
    controlSection.style.setProperty("width", "95.5%", "important");
    resizeManualTrigger = true;
    window.dispatchEvent(new Event('resize'));
    resizeManualTrigger = false;
    requestAnimationFrame(function () {
       propertySection.classList.add('add-transition');
       controlSection.classList.add('add-transition');
    });


    btn.addEventListener("click", () => {
            isOpen = !isOpen;

        if (isOpen) {
                contentRoot.classList.add('sb-prop-panel-open');
                propertySection.style.display = "block";
                propertySection.style.setProperty("width", "34.3333%", "important");
                controlSection.style.setProperty("width", "65.6667%", "important");
                controlSection.classList.add('sb-property-no-border');
                controlSection.classList.remove('sb-property-border');
            }
        else {
                contentRoot.classList.remove('sb-prop-panel-open');
                propertySection.style.display = "none";
                propertySection.style.setProperty("width", "5%", "important");
                controlSection.style.setProperty("width", "95.5%", "important");
                controlSection.classList.remove('sb-property-no-border');
                controlSection.classList.add('sb-property-border');
            }
            setTimeout(() => {
                window.dispatchEvent(new Event('resize'));
            }, 0);
        });
    contentRoot.appendChild(btn);
    return btn;
}
ensureToggleButton();