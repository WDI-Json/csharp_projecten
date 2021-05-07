namespace KnutselenBlazor.Models
{
/*
The alert model defines the properties of an alert, and the AlertType enum defines the different types of alerts supported by the application.

The model and enum are used by the alert service and alert component for sending, receiving and displaying alerts in the blazor app.

*/    
    public class Alert
    {
        public string Id { get; set; }
        public AlertType Type { get; set; }
        public string Message { get; set; }
        public bool AutoClose { get; set; }
        public bool KeepAfterRouteChange { get; set; }
        public bool Fade { get; set; }
    }

    public enum AlertType
    {
        Success,
        Error,
        Info,
        Warning
    }
}