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

