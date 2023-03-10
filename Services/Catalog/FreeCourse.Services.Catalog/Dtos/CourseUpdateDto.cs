namespace FreeCourse.Services.Catalog.Dtos
{
    internal class CourseUpdateDto
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public string UserId { get; set; }
        public string picture{ get; set; }
        public FeatureDto Feature { get; set; }
        public string CategoryId { get; set; }
    }
}
