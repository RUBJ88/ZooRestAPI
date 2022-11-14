namespace Zoo.Manager
{
    public class Item
    {
        public Item(int? lowerQuantity, int? highQuantity)
        {
            LowerQuantity = lowerQuantity;
            HighQuantity = highQuantity;
        }

        public int? LowerQuantity { get; set; }
        public int? HighQuantity { get; set; }

    }
    public record ItemsRecord(int? LowerQuantity, int? HighQuantity);
}
    