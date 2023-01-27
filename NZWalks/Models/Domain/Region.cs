namespace NZWalks.Models.Domain
{
    public class Region
    {
        public Guid ID { get; set; }

        public string Code { get; set; }


        public string Name { get; set; }

        public float Area { get; set; }

        public double Lat { get; set; }

        public double Long { get; set; }

        public long Population { get; set; }

        //Navigation property.
        public IEnumerable<Walk>  Walks{ get; set; }
    }
}
