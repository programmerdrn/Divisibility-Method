🔢 Divisibility Method - C# Math Utility
یک کتابخانه ساده و کارآمد برای بررسی تقسیم‌پذیری اعداد در C#

https://img.shields.io/badge/C%2523-239120?style=for-the-badge&logo=c-sharp&logoColor=white
https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white
https://img.shields.io/badge/GitHub-Open%2520Source-181717?style=for-the-badge&logo=github
https://img.shields.io/badge/License-MIT-green?style=for-the-badge

✨ ویژگی‌ها
✅ بررسی تقسیم‌پذیری اعداد بر اعداد ۲ تا ۱۰

✅ الگوریتم‌های بهینه‌شده برای محاسبات سریع

✅ کتابخانه سبک و بدون وابستگی

✅ مناسب برای پروژه‌های آموزشی و ریاضی

✅ کدهای تمیز و قابل توسعه

🚀 نحوه استفاده
پیش‌نیازها
.NET 6.0 یا بالاتر

نصب و راه‌اندازی
bash
# کلون کردن ریپوزیتوری
git clone https://github.com/programmerdrn/Divisibility-Method.git
cd Divisibility-Method

# اجرای پروژه
dotnet run
📖 مثال‌های کد
csharp
using DivisibilityMethod;

// ایجاد نمونه از کلاس
var divisibility = new Divisibility();

// بررسی تقسیم‌پذیری
int number = 15;

Console.WriteLine($"آیا {number} بر ۳ تقسیم می‌شود؟ {divisibility.DivideBy3(number)}");
Console.WriteLine($"آیا {number} بر ۵ تقسیم می‌شود؟ {divisibility.DivideBy5(number)}");

// خروجی:
// آیا 15 بر ۳ تقسیم می‌شود؟ True
// آیا 15 بر ۵ تقسیم می‌شود؟ True
🎯 متدهای موجود
متد	توضیح	مثال
DivideBy2(int number)	تقسیم بر ۲	DivideBy2(10) → true
DivideBy3(int number)	تقسیم بر ۳	DivideBy3(9) → true
DivideBy4(int number)	تقسیم بر ۴	DivideBy4(16) → true
DivideBy5(int number)	تقسیم بر ۵	DivideBy5(25) → true
DivideBy6(int number)	تقسیم بر ۶	DivideBy6(12) → true
DivideBy7(int number)	تقسیم بر ۷	DivideBy7(14) → true
DivideBy8(int number)	تقسیم بر ۸	DivideBy8(24) → true
DivideBy9(int number)	تقسیم بر ۹	DivideBy9(18) → true
DivideBy10(int number)	تقسیم بر ۱۰	DivideBy10(100) → true
🏗️ ساختار پروژه
text
Divisibility-Method/
├── DivisibilityMethod/
│   ├── Divisibility.cs     # کلاس اصلی کتابخانه
│   └── DivisibilityMethod.csproj
├── DivisibilityMethod.Tests/
│   ├── UnitTest1.cs        # تست‌های واحد
│   └── DivisibilityMethod.Tests.csproj
└── README.md
🧪 اجرای تست‌ها
bash
# اجرای تست‌های واحد
dotnet test
🤝 مشارکت در پروژه
مشارکت‌های شما باعث رشد این پروژه می‌شود!

ریپو را Fork کنید

Branch جدید بسازید (git checkout -b feature/AmazingFeature)

تغییرات را Commit کنید (git commit -m 'Add AmazingFeature')

Branch را Push کنید (git push origin feature/AmazingFeature)

Pull Request ایجاد کنید

📄 لایسنس
این پروژه تحت لایسنس MIT منتشر شده است. برای اطلاعات بیشتر فایل LICENSE را مطالعه کنید.

👨‍💻 توسعه‌دهنده
programmerdrn - GitHub Profile

⭐ اگر این پروژه برایتان مفید بود، حتما به آن Star بدهید!

📞 ارتباط با من
GitHub: @programmerdrn

برای سوالات و پیشنهادات می‌توانید Issue جدید ایجاد کنید.
