using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ST10263794_CLDV6211_POE_Part1.Pages
{
    public class MyWorkModel : PageModel
    {
        public void OnGet()
        {
            
            var craftworks = GetCraftworksFromDatabase();
            ViewData["Craftworks"] = craftworks;
        }

        
        private List<Craftwork> GetCraftworksFromDatabase()
        {
          
            return new List<Craftwork>
            {
                new Craftwork { Title = "Pottery", Description = "Handcrafted with care and creativity, our pottery pieces are a testament to the beauty of traditional craftsmanship. Each piece is lovingly molded and fired by skilled artisans, resulting in unique and charming creations that add character to any space. Whether you're looking for a rustic vase, a whimsical mug, or a one-of-a-kind sculpture, our pottery collection offers something for every taste and style", Price = 800, ImagePath = "/images/image1.jpg" },
                new Craftwork { Title = "Paintings", Description = "Dive into a world of color and expression with our collection of hand-painted artworks. From vibrant abstract compositions to serene landscapes, each painting is a labor of love crafted by talented artists. Using a variety of techniques and mediums, our artists bring their visions to life on canvas, creating captivating pieces that stir the imagination and ignite the soul", Price = 850, ImagePath = "/images/image2.jpg" },
                new Craftwork { Title = "Craftwork", Description = "Explore the artistry of handmade crafts with our eclectic collection of DIY creations. From intricately woven textiles to meticulously crafted woodwork, each piece showcases the skill and ingenuity of our artisans. Whether you're drawn to the rustic charm of hand-carved ornaments or the intricate detail of woven tapestries, our craftwork collection celebrates the beauty of traditional craftsmanship in a modern context.", Price = 1000, ImagePath = "/images/image3.jpg" }
            };
        }
    }

    public class Craftwork
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImagePath { get; set; }
    }
}

