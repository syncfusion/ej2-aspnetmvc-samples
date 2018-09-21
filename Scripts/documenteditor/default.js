var isReadOnly = false;
var documenteditor;
var containerPanel;
document.addEventListener('DOMContentLoaded', function () {
    containerPanel = document.getElementById('documenteditor_container_body');
    documenteditor = document.getElementById('container').ej2_instances[0];
    documenteditor.acceptTab = true;
    documenteditor.enableAllModules();

    document.getElementById('documenteditor_titlebar').style.display = '';
    document.getElementById('documenteditor_statusbar').style.display = '';
    titleBarDiv = document.getElementById('documenteditor_titlebar');
    toolBarDiv = document.getElementById('documenteditor_toolbar');
    statusBarDiv = document.getElementById('documenteditor_statusbar');
    toolBarDiv.style.border = '1px solid #e4e4e4';
    tocElementId = documenteditor.element.id;
    imageElementId = documenteditor.element.id;

    var documenteditorElement = document.getElementById("container");
    documenteditorElement.style.height = "100%";
    documenteditorElement.style.width = "100%";
    documenteditor.pageOutline = '#E0E0E0';

    initComponentAndWireEvent();
    var panel = document.getElementById('panel');
    panel.style.display = 'block';
    updateContainerSize();
    documenteditor.resize();
    onLoadDefault();
    applyPageCountAndDocumentTitle();
    showPropertiesPaneOnSelection();
    updateStyleNames();
    documenteditor.focusIn();
    documenteditor.documentChange = function (args) {
        updateUndoRedoBtn();
        isContentChange = false;
        applyPageCountAndDocumentTitle();
        updateStyleNames();
    };
    documenteditor.contentChange = function (args) {
        isContentChange = true;
        if (!isReadOnly) {
            updateUndoRedoBtn();
        }
        updatePageCount();
    };
    documenteditor.selectionChange = function (args) {
        setTimeout(function () { onSelectionChange(); }, 20)
    };
    documenteditor.requestNavigate = function (args) {
        if (args.linkType !== 'Bookmark') {
            var link = args.navigationLink;
            if (args.localReference.length > 0) {
                link += '#' + args.localReference;
            }
            window.open(link);
            args.isHandled = true;
        }
    };
    documenteditor.zoomFactorChange = function () {
        updateZoomContent();
    };
    documenteditor.viewChange = function (e) {
        updatePageNumberOnViewChange(e);
    };
    setTimeout(function(){ onSelectionChange(); }, 20);    
});
function applyPageCountAndDocumentTitle() {
    updateDocumentTitle();
    updatePageCount();
}
function updateContainerSize() {
    if (containerPanel) {
        containerPanel.style.height = window.innerHeight - (document.getElementById('documenteditor_titlebar').offsetHeight
            + document.getElementById('documenteditor_toolbar').offsetHeight +
            document.getElementById('documenteditor_statusbar').offsetHeight)
            + 'px';
    }
}
function onSelectionChange() {
    if (documenteditor.selection) {
        startPage = documenteditor.selection.startPage;
        updatePageNumber();
        showPropertiesPaneOnSelection();
    }
}

function updateDocumentTitle() {
    if (documenteditor.documentName == '') {
        documenteditor.documentName = 'Untitled';
    }
    document.getElementById('documenteditor_title_name').textContent = documenteditor.documentName;
}

function updatePageCount() {
    document.getElementById('documenteditor_pagecount').textContent = documenteditor.pageCount;
}
function showHidePropertyOptions(args) {
    var highlightColor = document.getElementById('highlight_color_ppty');
    var element = (navigator.userAgent.indexOf('Chrome') !== -1 || navigator.userAgent.indexOf('Firefox') !== -1) ? args.target.parentElement : args.target;
    var highlightSpinButton = document.getElementById('font_properties_highlightColor_dropdownbtn');
    if ((element.id === 'font_properties_highlightColor_dropdownbtn' || element.contains(highlightSpinButton)) && highlightColor.style.display === 'none') {
        highlightColor.style.display = 'block';
    } else {
        highlightColor.style.display = 'none';
    }
}