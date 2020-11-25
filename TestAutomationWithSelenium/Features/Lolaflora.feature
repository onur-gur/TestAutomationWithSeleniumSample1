Feature: Lolaflora
	https://www.lolaflora.com/login adresine gidilir ve e-mail,password alanları 
	doldurulup oturum aç butonuna tıklanır eğer e-mail ve password değerleri yanlış ise
	bu alanlar geçersiz uyarısı alınır, email ve password alanlarının geçersiz değerler girilip
	bu alanların kontrolü yapılır

@mytag
Scenario: LoginAndLogOut
	* 'https://www.lolaflora.com/login' adresine gidilir
	* Email alanına 'your_email_adress' yazılır
	* Password alanına  'your_password' yazılır
	* Sign In elementine tıklanır
	* Çıkan popup kapatılır
	* Logout butonuna tıklanır
	* Url 'https://www.lolaflora.com/' ana sayfa olduğu kontrol edilir

Scenario: SignInWithWrongPassword
	* 'https://www.lolaflora.com/login' adresine gidilir
	* Email alanına 'your_email_adress' yazılır
	* Password alanına  'yanlış_şifre' yazılır
	* Sign In elementine tıklanır
	* 'E-mail address or password is incorrect' uyarısı alınır

Scenario: InvalidEmail
	* 'https://www.lolaflora.com/login' adresine gidilir
	* Email alanına 'your_email_adress' yazılır
	* Password alanına  '123456789' yazılır
	* Sign In elementine tıklanır
	* Geçersiz email adresi için 'Please enter a valid e-mail address.' uyarısı alınır

Scenario: InvalidShortPassword
	* 'https://www.lolaflora.com/login' adresine gidilir
	* Email alanına 'your@email.com' yazılır
	* Password alanına  '12' yazılır
	* Sign In elementine tıklanır
	* Geçersiz password için 'Please enter minimum 3 and maximum 20 characters.' uyarısı alınır

Scenario: InvalidPassword
	* 'https://www.lolaflora.com/login' adresine gidilir
	* Email alanına 'your@email.com' yazılır
	* Password alanına  '01234567890qwertyuıopğ' yazılır
	* Sign In elementine tıklanır
	* Geçersiz password için 'Please enter minimum 3 and maximum 20 characters.' uyarısı alınır

Scenario: LoginWihoutEmailAndPassword
	* 'https://www.lolaflora.com/login' adresine gidilir
	* Email alanına ' ' yazılır
	* Password alanına  ' ' yazılır
	* Sign In elementine tıklanır	
	* Geçersiz email adresi için 'Required field.' uyarısı alınır
	* Geçersiz password için 'Required field.' uyarısı alınır

Scenario:ForgotPassword
	* 'https://www.lolaflora.com/login' adresine gidilir
	* Şifremi unuttum elementine tıklanır
	* Mail adresi 'your@email.com' girilir
	* Send butonuna tıklanır
	* Unutulan şifre için 'You will receive an e-mail from us with instructions for resetting your password.' uyarısı alınır

Scenario:ForgotPasswordInvalidMail
	* 'https://www.lolaflora.com/login' adresine gidilir
	* Şifremi unuttum elementine tıklanır
	* Mail adresi 'your_email_adress' girilir
	* Send butonuna tıklanır
	* Email doğrumanadı 'Please enter a valid e-mail address.' uyarısı alınır