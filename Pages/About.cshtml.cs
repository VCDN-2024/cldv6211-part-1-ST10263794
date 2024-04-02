using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ST10263794_CLDV6211_POE_Part1.Pages
{
    public class AboutModel : PageModel
    {
        public void OnGet()
        {
            
            ViewData["CompanyInfo"] = "Welcome to KhumaloCraft Emporium, the brainchild of visionary entrepreneur James Khumalo. With a passion for connecting artisans worldwide with a discerning audience, James embarked on a journey to establish KhumaloCraft Emporium as a global e-commerce platform showcasing handcrafted products from around the world.\r\n\r\nAt KhumaloCraft Emporium, our mission is simple yet profound: to create a platform that is scalable, accessible, and user-friendly, offering a seamless shopping experience to our global audience. With a deep understanding of basic cloud computing and various service models, we have built a platform that not only showcases the exquisite craftwork of artisans but also ensures a secure and enjoyable shopping experience for our customers.\r\n\r\nOur development team has faced numerous technical challenges along the way, from designing an efficient database schema for product information and user data to ensuring global accessibility and scalability. But through dedication and innovation, we have overcome these challenges to create a platform that exceeds expectations.\r\n\r\nWhether you're browsing our curated collection of handcrafted treasures or connecting with artisans from across the globe, KhumaloCraft Emporium is your gateway to a world of creativity and craftsmanship. Join us on this journey as we continue to grow and evolve, bringing the beauty of handmade products to a global audience.\r\n\r\nThank you for choosing KhumaloCraft Emporium. We invite you to explore our platform and discover the magic of artisanal craftsmanship, one masterpiece at a time.";
        }
    }
}
