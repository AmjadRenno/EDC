# دليل سريع لرفع المشروع على GitHub

## 🚀 الخطوات المطلوبة

### 1. إنشاء مستودع على GitHub
1. اذهب إلى https://github.com/new
2. **اسم المستودع**: `EDC-Real-Estate-Management`
3. **الوصف**: `Internal real estate management system - University coursework project (First semester)`
4. **عام** ✅ (للسيرة الذاتية)
5. **لا تقم بالتهيئة** مع README (لدينا واحد)
6. اضغط **"Create repository"**

### 2. رفع المشروع
افتح PowerShell في مجلد المشروع وقم بتنفيذ هذه الأوامر:

```bash
# الانتقال لمجلد المشروع
cd "C:\Users\Amjad\Downloads\Database1.SemesterProjektSolution-master\C#\Forms\EDC"

# تهيئة Git
git init

# إضافة جميع الملفات
git add .

# إنشاء أول commit
git commit -m "Initial commit: EDC Real Estate Management System

- مشروع جامعي للفصل الدراسي الأول
- نظام إدارة عقارات داخلي شامل
- واجهات حديثة باللغة الدنماركية
- عمليات CRUD كاملة للمشروع"

# ربط بـ GitHub (استبدل yourusername باسم المستخدم الخاص بك)
git remote add origin https://github.com/yourusername/EDC-Real-Estate-Management.git

# رفع للـ GitHub
git branch -M main
git push -u origin main
```

### 3. إعداد المستودع
بعد الرفع:
1. **إضافة المواضيع**: `csharp`, `dotnet`, `windows-forms`, `real-estate`, `university-project`
2. **تمكين Issues والمشاريع**
3. **التأكد من عرض README بشكل صحيح**

## ✅ المشروع جاهز للعرض!

المشروع الآن منظم ومهيأ للعرض المهني مع:
- ✅ ملف README مختصر ومهني
- ✅ وثائق شاملة
- ✅ صور توضيحية
- ✅ هيكل نظيف ومنظم
- ✅ إشارة واضحة للسياق الأكاديمي
- ✅ إخلاء مسؤولية مناسب

🎓 مشروع جامعي احترافي جاهز للعرض على أصحاب العمل!
