namespace OOP
{
    class Cars
    {
        string model;       //1.Model (string): Mashinaning modeli.
        int year;           //2.Year (int): Mashinaning ishlab chiqarilgan yili. 
        decimal price;       //3.Price (decimal): Mashinaning narxi. 
        decimal speed;       //4.Speed (decimal): Mashinaning tezligi.
        
        //Ob'ektni boshlang'ich qiymatlarini (marka, model, yil, narx) o'rnatish uchun parametrlarni qabul qiladigan constructor. 
       public Cars(string model, int year, decimal price, decimal speed)
        {
            this.model = model;
            this.year = year;  
            this.price = price;
            this.speed = speed;
        }
        //Barcha xususiyatlarga kirishni ruxsat beradigan getter va setterlar (xususiyatlar). 
        public string Model{ get {return model;} set {model = value;}}
        public int Year{ get  {return year;} set {year = value; }}
        public decimal Price{ get{return price;} set{price = value;}}
        public decimal Speed{ get {return speed;} set{speed = value;}}

        //GetCarInfo() deb nomlangan metod, mashina haqida barcha ma'lumotlarni (marka, model, yil, narx) qaytaradigan string. 
        public string GetCarInfo()
        {
            return $"Model - {model}\nIshlab chiqarilgan yili - {year}\nNarxi - ${price}\nTezligi - {speed}";
        }
        /* 
            CalculateDepreciation(int years) deb nomlangan metod,
            mashina qiymatining yaratilgan yildan boshlab yillar o'tganda qancha kamayishini hisoblaydigan funktsiya. 
            Yillik 10%lik kamayish qiymatini o'limoq.
        */
        public void CalculateDepreciation(int years)
        {
            System.Console.WriteLine($"Mashinaning {years} yil foydalanilgandan keyingi qiymati: $" + (price - price*(0.1m)*(years)));
            //  Bunda Depreciationni tushunganim bo'yicha hisobladim. 
            //Years obyekt yaratilguncha kiritiladi yoki User tomonidan kiritiladi deb olindi
        }
    }
}