using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Phase4Assesment.Models
{
    public class PizzaBO
    {
        public static List<PizzaModel> Items;
        public PizzaBO()
        {
            Items = new List<PizzaModel>
            {
                new PizzaModel{
                    PizzaId=1,
                    PName="Cheese and corn",
                    Crust="Medium",
                    Description="Nice baked and cheese allaround",
                    Price=550,
                    Image="https://pizzawings.co.in/wp-content/uploads/2020/12/Cheese-Golden-Corn.jpg"
                },
                new PizzaModel{
                    PizzaId=2,
                    PName="Mexican ",
                    Crust="Regular",
                    Description="Delicious on every bite,enjoy multiple toppings",
                    Price=450,
                    Image="https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fstatic.onecms.io%2Fwp-content%2Fuploads%2Fsites%2F38%2F2019%2F11%2FRU189152.jpg&q=85"
                },
                new PizzaModel{
                    PizzaId=3,
                    PName="Deluxe  Veggie",
                    Crust="large",
                    Description="A large pizza with all toppings from dominos",
                    Price=350,
                    Image="https://tmbidigitalassetsazure.blob.core.windows.net/rms3-prod/attachments/37/1200x1200/Veggie-Pizza-with-Herbed-Tomato-Crust_EXPS_HRBZ17_36065_B09_06_1b.jpg"
                },
                new PizzaModel{
                     PizzaId=4,
                    PName="Margherita",
                    Crust="Medium",
                    Description="A delicious mozerella cheese topping",
                    Price=350,
                    Image="https://cdn.shopify.com/s/files/1/2321/3015/products/delicious_italian_pizza_1_570x570_crop_top.png?v=1504536560"
                },
                new PizzaModel{
                     PizzaId=5,
                    PName="Peperoni",
                    Crust="Small",
                    Description="Spicy on every bite you take",
                    Price=250,
                    Image="https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/pepperoni-pizza-lasagna-roll-ups-1601561536.jpg?crop=0.760xw:0.998xh;0.0697xw,0.00218xh&resize=640:*"
                },
                new PizzaModel{
                     PizzaId=6,
                    PName="Cheesy Pizza",
                    Crust="Medium",
                    Description="A super crusted pizza with all toppings",
                    Image="https://static.toiimg.com/thumb/53110049.cms?imgsize=148092&width=800&height=800"
                },
                  new PizzaModel{
                     PizzaId=7,
                    PName="American Pizza",
                    Crust="Medium",
                    Description="A super crusted pizza with all toppings",
                    Image="http://simply-delicious-food.com/wp-content/uploads/2020/06/Grilled-Pizza-Margherita-3.jpg"
                }
            };
        }
        public List<PizzaModel> GetItems()
        {
            return Items;
        }
        public PizzaModel GetItemById(int id)
        {
            return Items.Find(x => x.PizzaId == id);
        }
        public string GetItemByName(int id)
        {
            var key=Items.Find(x => x.PizzaId == id);
            return key.PName;
        }
    }
}
