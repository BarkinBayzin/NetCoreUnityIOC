# Authentication And Authorization

Kimlik doğrulama ve yetkilendirme arasındaki farkı açıklamak için bir örnek verelim. 
İlk olarak, kimlik doğrulama. Rezervasyonlu bir otele gittiğinizde sizden ilk istedikleri şey bir çeşit kimliktir çünkü
ancak o zaman sizin kim olduğunuzu kesin olarak bilirler. 
Bunu biliyorlar çünkü belgede kimlik numaranız, adınız ve doğum tarihiniz gibi belirli bilgiler bulunmaktadır.
Bu bu bilgiler kimliğinizi oluşturur. Kimlik doğrulama, birinin kimliğini belirlemekle ilgilidir.
Herkesin %100 dürüst olduğu bir dünyada, bir kişiye sadece kimliğini sormanız yeterli olacaktır. 
Ama ne yazık ki, durum böyle değil. Kişinin doğruyu söylediğine dair bir kanıtımız olmalı. 
Otelin pasaporta ihtiyacı var. Bir uygulama genellikle bir parolaya ihtiyaç duyar. 
Bir uygulamada, sağladığınız kullanıcı adının gerçekten siz olup olmadığını kontrol etmek için genellikle bir şifre verilmesi gerekir. 
Bu ortadan kalktığında, doğum tarihi, doğum yeri vb. gibi sizinle ilgili diğer bilgiler başvuruya sunulur. 
Ancak talepler, çalışan numarası veya departman gibi kuruluşa özel de olabilir. 
ASP.NET Core'da, kimlik doğrulaması yapmak için bir dizi seçenek arasından seçim yapabilirsiniz. 
Bu örnekte, kimlik doğrulaması yapmak için en temel olanı, 
ASP.NET Core'daki Identity yalnızca Kimlik tanımlama bilgisi desteğidir. 
ASP.NET Core Identity de bunu kullanır, ancak çevresinde eksiksiz bir çerçeve sunar. 
Son olarak, kimlik doğrulamanın yalnızca bir uygulamanın kapsamının ötesine geçmesi gerekiyorsa, 
bir OpenID Connect kimlik sağlayıcısı kullanabiliriz. 
Şimdi, yetkilendirme nedir? Analojiye dönelim. 
Otel, kim olduğunuzdan emin olduktan sonra, size bir otel anahtarı verilir,
ancak pasaportta belirli talepler kontrol edilmeden önce değil. 
Belki otel görevlisi sadece isim talebinizi kontrol eder, ancak aynı zamanda doğum tarihi talebinizi de kontrol edebilir. 
Otel anahtarı, binanın yalnızca belirli bölümlerine erişmenizi sağlar. 
Elbette kendi odanızın kapısını açabilirsiniz ama havuzun kapısını da açabilirsiniz ama diğer odaların kapılarını açamazsınız. 
Bu durumda anahtar size otel binasına sınırlı erişim sağlar. 
Buna yetkilendirme denir. Birinin ne yapabileceğiyle ilgili, ancak birinin ne yapabileceği ancak önce bir tür kimlik doğrulama varsa belirlenebilir. 
Yetkilendirme, ASP.NET Core'a karmaşık bir şekilde yerleştirilmiştir.
