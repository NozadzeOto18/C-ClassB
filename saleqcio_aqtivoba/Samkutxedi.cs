using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace saleqcio_aqtivoba
{
    /*შეადგინეთ სამკუთხედის კლასი, რომელშიც განსაზღვრულია ერთი და იგივე
    სახელის მქონე 2 მეთოდი. პირველ მეთოდს 2 მთელრიცხვა პარამეტრი აქვს:
    სამკუთხედის სიმაღლე და ფუძე და აბრუნებს მართკუთხა სამკუთხედის
    ფართობს. მეორე მეთოდს 3 მთელრიცხვა პარამეტრი აქვს: სამკუთხედის
    გვერდები და აბრუნებს სამკუთხედის პერიმეტრს. ძირითად პროგრამაში
    შექმენით შესაბამისი ობიექტი და გამოიძახეთ ორივე მეთოდი.*/
    class Samkutxedi
    {
        public int gverdi_1, gverdi_2, gverdi_3, simagle, fudze;
        private int fart_samk, perim_samk;

        public int Samkutxedi1(int simagle, int fudze)
        {
            this.simagle = simagle;
            this.fudze = fudze;
            fart_samk = (this.simagle * this.fudze) / 2;
            return fart_samk;
        }
        public int Samkutxedi1(int gverdi_1, int gverdi_2, int gverdi_3)
        {
            this.gverdi_1 = gverdi_1;
            this.gverdi_2 = gverdi_2;
            this.gverdi_3 = gverdi_3;
            perim_samk = this.gverdi_1 + this.gverdi_2 + this.gverdi_3;
            return perim_samk;
        }
    }
}
