namespace BringApi.Net
{
    public static class BringTrackingStatus
    {
        public static string ArrivedCollection => "ARRIVED_COLLECTION";
        public static string ArrivedDelivery => "ARRIVED_DELIVERY";
        public static string Customs => "CUSTOMS";
        public static string Collected => "COLLECTED";
        public static string Delivered => "DELIVERED";
        public static string DeliveryCancelled => "DELIVERY_CANCELLED";
        public static string DeliveryChanged => "DELIVERY_CHANGED";
        public static string DeliveryOrdered => "DELIVERY_ORDERED";
        public static string Deviation => "DEVIATION";
        public static string HandedIn => "HANDED_IN";
        public static string International => "INTERNATIONAL";
        public static string InTransit => "IN_TRANSIT";
        public static string NotificationSent => "NOTIFICATION_SENT";
        public static string PreNotified => "PRE_NOTIFIED";
        public static string ReadyForPickup => "READY_FOR_PICKUP";
        public static string Return => "RETURN";
        public static string TransportToRecipient => "TRANSPORT_TO_RECIPIENT";
    }
}
