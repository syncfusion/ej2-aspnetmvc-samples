var switcherPopup;
var themeSwitherPopup;
var openedPopup;
var searchPopup;
var settingsPopup;
var sidebar;
var settingsidebar;
var prevAction;
var searchInstance;
var isStaging = document.body.dataset.isStaging === "true";
var headerThemeSwitch = document.getElementById('header-theme-switcher');
var settingElement = ej.base.select('.sb-setting-btn');
var themeList = document.getElementById('themelist');
var themes = isStaging ? ['material', 'material3', 'fabric', 'fluent', 'fluent2', 'bootstrap', 'bootstrap4', 'bootstrap5', 'bootstrap5.3', 'tailwind', 'tailwind3', 'highcontrast', 'fluent2-highcontrast']  : ['material3', 'fluent', 'fluent2', 'bootstrap5.3', 'tailwind3', 'highcontrast', 'fluent2-highcontrast'];
//var themes= ['material3', 'material3-dark', 'fluent', 'fluent-dark', 'bootstrap5', 'bootstrap5-dark', 'tailwind', 'tailwind-dark', 'highcontrast'];
var defaultTheme = 'tailwind3';
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
var sampleNavigation = "<div class=\"sb-custom-item sample-navigation\"><button id='prev-sample' type='button' class=\"sb-navigation-prev\" \n    aria-label=\"previous sample\">\n<span class='sb-icons sb-icon-Previous'></span>\n</button>\n<button  id='next-sample' type='button' class=\"sb-navigation-next\" aria-label=\"next sample\">\n<span class='sb-icons sb-icon-Next'></span>\n</button>\n</div>";
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
            var localtheme = localStorage.getItem("currentTheme");
            // If "-dark" is present in the URL, modify the value accordingly
            if (localtheme != null && localtheme.includes("-dark") && e.value != "highcontrast" && e.value != "fluent2-highcontrast" && e.value != "bootstrap4") {
                if (isDarkModeURL() || window.location.href.includes('highcontrast') || window.location.href.includes('fluent2-highcontrast') || window.location.href.includes('bootstrap4')) {
                    e.value += "-dark";
                }
            } 
            switchTheme(e.value);
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
    var tabHeader = document.getElementById('sb-content-header');
    tabHeader.appendChild(tabContentToolbar);
    var previous = new ej.popups.Tooltip({
        content: 'Previous Sample'
    });
    previous.appendTo('#prev-sample');

    var next = new ej.popups.Tooltip({
        content: 'Next Sample'
    });

    next.appendTo('#next-sample');
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
            setPressedAttribute(headerThemeSwitch);
            curPopup = themeSwitherPopup;
            break;
        case 'toggleSettings':
            settingElement.classList.toggle('active');
            headerThemeSwitch.classList.remove('active');
            setPressedAttribute(settingElement);
            themeDropDown.index = themes.indexOf(selectedTheme);
            curPopup = settingsPopup;
            break;
    }
    if (action === 'closePopup') {
        headerThemeSwitch.classList.remove('active');
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
            ej.base.select('.sb-mobile-prop-pane').appendChild(propPanel);
            ej.base.select('.sb-mobile-setting').classList.remove('sb-hide');
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
        var mobilePropPane = ej.base.select('.sb-mobile-prop-pane .property-section');
        if (mobilePropPane) {
            ej.base.select('#control-content').appendChild(mobilePropPane);
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
    document.addEventListener('click', sbHeaderClick.bind(this, 'closePopup'));
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
        location.href = location.origin + getPathName() + curhref + '#/' + theme;
    }
    window.hashString = location.origin + getPathName() + curhref + '#/' + theme;
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
    if (currentUpdatedTheme != "tailwind")
    {
        currentUpdatedTheme == 'bootstrap5.3' ? themeList.querySelector('#bootstrap5\\.3').classList.add('active') : themeList.querySelector('#' + currentUpdatedTheme).classList.add('active');
    }
    var path = location.origin + baseurl;
    var ajax = new ej.base.Ajax(path + 'Content/styles/' + theme + '.css', 'GET', false);
    selectedTheme = theme;
    var rightPaneSB = document.getElementById('right-pane');
    if (rightPaneSB) {
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
    script.src = window.baseurl + 'Scripts/search-index.js';
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

function getSampleList() {
    if (ej.base.Browser.isDevice) {
        var tempList = ej.base.extend([], window.samplesList);
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
                        location.href = location.origin + getPathName() + `grid/gridoverview#/${defaultTheme}`
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
    return window.samplesList;
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
                            location.href = location.origin + pathName + arg.data.dir.toLowerCase() + '/' + arg.data.url.toLowerCase() + '#/' + theme;
                        }
                        else {
                            location.href = location.origin + pathName + arg.data.dir.toLowerCase() + '/' + defaultSample[0].url.toLowerCase() + '#/' + theme;
                        }                    }
                    else {
                        location.href = location.origin + pathName + arg.data.dir.toLowerCase() + '/' + arg.data.url.toLowerCase() + '#/' + theme;
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
    if (isMobile) {
        if (propPanel) {
            ej.base.select('.sb-mobile-setting').classList.remove('sb-hide');
            ej.base.select('.sb-mobile-prop-pane').appendChild(propPanel);
        } else {
            ej.base.select('.sb-mobile-setting').classList.add('sb-hide');
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
    loadStylesheet(window.baseurl + "Content/styles/highlight.css");
    loadStylesheet(window.baseurl + "Content/styles/roboto.css");
     if (window.location.href.includes("richtexteditor/onlinehtmleditor") || window.location.href.includes("richtexteditor/overview") || window.location.href.includes("richtexteditor/enterkey")) {
        loadStylesheet(window.baseurl + "Content/RichTextEditor/codemirror.css");
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
    var switchText = localStorage.getItem('ej2-switch') || 'mouse';
    var switchlocalization = sessionStorage.getItem('ej2-culture') || 'en';
    if (ej.base.Browser.isDevice || window.screen.width <= 850) {
        switchText = 'touch';
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
