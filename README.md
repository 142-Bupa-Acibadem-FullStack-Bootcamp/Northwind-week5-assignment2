Bu sisteme kullanıcının kendisinin kayıt olduğunu düşünerek;

Kullanıcı kayıt işlemlerini gerçekleştiren metod(ları) yazınız.

Kullanıcı kayıt işlemlerini; kullanıcı kayıt sırasında girdiği paralanın veri tabanına şifreli olarak kayıt olacak şekilde tasarlayınız.. 
 
# MD5,SHA1,MD5 (SHA1),SHA1 (MD5) algoritmalarını tercih edebilirsiniz. 
 
#### Eklenen MD5 ŞİFRELEME Metodu
```cs
  using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.ASCII.GetBytes(text);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to hexadecimal string
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
```
Veritabanına md5 ile şifrelenmiş biçimde kaydedildi.
![md5](https://user-images.githubusercontent.com/67828030/150515313-2c6fcadc-9516-49d6-a6f8-a604896f03f4.PNG)

#### Ek olarak
Customer tablosu Id si string olduğundan string id metodu eklendi.(dal-interface-bll-conroller)
CustomerManager örnek
```cs
 public IResponse<Customer> GetInclude(string str)
        {
            var customer = customerRepository.Get(str);
            if(customer != null)
            {
                                             return new Response<Customer>
                {
                    StatusCode = StatusCodes.Status200OK,
                    Message = "Success",
                    Data = ObjectMapper.Mapper.Map<Customer>(customer)
                };
            } 
            else 
            {
                return new Response<Customer>
                {
                    StatusCode = StatusCodes.Status500InternalServerError,
                    Message = "id bulunamadı",
                    Data = null
                };
            }
        }
```
#### 2. Ek olarak 
lazyLoading yapısı kaldırıldı. Customer'a Get isteği yapıdlığı zaman customer ile birlikte order 'ları gelmesi sağlandı
![customer](https://user-images.githubusercontent.com/67828030/150514428-5905765b-9bcd-4107-8011-277b45e04a17.PNG)
