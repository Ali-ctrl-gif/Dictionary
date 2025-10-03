//Dictionary<int, string> IDictionary = new Dictionary<int, string>();
//IDictionary.Add(1, "yek");
//IDictionary.Add(5, "pang");
//IDictionary.Add(3, "seh");

//foreach (var vk in IDictionary)
//{
//    Console.WriteLine("{0} : {1}",vk.Key,vk.Value);
//}
//Console.BackgroundColor = ConsoleColor.Red;
//Console.ForegroundColor = ConsoleColor.Black;
//Dictionary<string,string>Cities=new Dictionary<string,string>();
//Cities.Add("IR", "Tehran , Qazvin , Karaj");
//Cities.Add("USA", "Shikago , NewYork , LA");
//Cities.Add("Russia", "SanpeterzBork , Mosko , Sidny");

//foreach (var city in Cities)
//{
//    Console.WriteLine("{0} : {1}",city.Key,city.Value);
//}
//Console.ReadLine();
//مسئله ۱: مدیریت موجودی انبار (Add, Update, Check Existence)
//سناریو: شما یک انبار کوچک دارید و موجودی اقلام را با استفاده از یک دیکشنری مدیریت می‌کنید.

//تعریف اولیه: یک دیکشنری به نام Inventory از نوع Dictionary<string, int> ایجاد کنید (کلید: نام محصول، مقدار: تعداد موجودی).

//عملیات مورد نیاز:

//افزودن: دو قلم جدید به انبار اضافه کنید: “مداد” با موجودی ۵۰ و “خودکار” با موجودی ۱۰۰.
//به‌روزرسانی: موجودی “مداد” را ۲۰ عدد افزایش دهید (باید به ۱۰۰ تبدیل شود).
//بررسی وجود: بررسی کنید که آیا محصول “دفتر” در انبار وجود دارد یا خیر. اگر وجود ندارد، آن را با موجودی ۳۰ اضافه کنید.
//نمایش: کل دیکشنری را چاپ کنید تا موجودی نهایی را ببینید.
//Console.BackgroundColor = ConsoleColor.Green;
//Console.ForegroundColor = ConsoleColor.Yellow;

//Dictionary<string,int> Inventory = new Dictionary<string,int>();
//Inventory.Add("Pencil", 50);
//Inventory.Add("Pen", 100);
////Inventory.Add("Pencil", 20);

//Inventory["Pencil"] += 20;
////Inventory.ContainsKey("Pencil") += 20;

//if (Inventory.ContainsKey("notbook"))
//{
//    Console.WriteLine("Yes it is");
//}
//else
//{
//    Inventory.Add("NoteBooK",30);
//}

//foreach (var notbook in Inventory)
//{
//    Console.WriteLine(notbook);
//}
//--------------------------------------------------------------------------------------