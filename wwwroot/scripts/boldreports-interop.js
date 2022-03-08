// Interop file to render the Bold Reports component with properties.
window.BoldReports = {
    RenderViewer: function (elementID, reportViewerOptions) {
        $("#" + elementID).boldReportViewer({
            reportPath: "sales-order-detail",
            reportServiceUrl: reportViewerOptions.serviceURL,
            reportServerUrl: "http://desktop-haphhh3/Reports/"
        });
    },
    RenderDesigner: function (elementID, reportDesignerOptions) {
        $("#" + elementID).boldReportDesigner({
            serviceUrl: reportDesignerOptions.serviceURL
        });
    }
}