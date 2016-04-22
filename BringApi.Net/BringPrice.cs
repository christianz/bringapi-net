namespace BringApi.Net
{
    public class BringPrice
    {
        public string CurrencyIdentificationCode { get; set; }
        public BringPackagePrice PackagePriceWithoutAdditionalServices { get; set; }
        public BringPackagePrice PackagePriceWithAdditionalServices { get; set; }
    }
}
