namespace ServiceLayer.DTOs.Slider
{
    public class SliderDto
    {
        public int Id { get; set; }

        public byte[] Image { get; set; }
        public string Title { get; set; }
        public string Desc { get; set; }
    }
}
