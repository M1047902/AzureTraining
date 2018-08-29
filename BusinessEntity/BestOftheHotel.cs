namespace BusinessEntity
{    
    public  class BestOftheHotel
    {
        public int HotelID { get; set; }
        public int MenuItemID { get; set; }
        public int NoofSuggenstions { get; set; }
    
        public  Hotel Hotel { get; set; }
        public  MenuItem MenuItem { get; set; }
    }
}
