package ecommerce.teste;

import java.util.concurrent.TimeUnit;

import org.junit.After;
import org.junit.Before;
import org.junit.Test;
import org.openqa.selenium.By;
import org.openqa.selenium.Keys;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.chrome.ChromeDriver;

public class TesteEcommerce {


	//carregar o webDriver
		private WebDriver driver;
		
	//inicio
	@Before
	public void ConfigurarTeste(){
		System.setProperty("webdriver.chrome.driver","C:\\Program Files\\ChromeDriver\\chromedriver.exe");
		driver = new ChromeDriver();
		driver.manage().window().maximize();
		
	}
	//teste
	
	
	@Test
	public void TesteLoginErroSenha() {
		driver.get("http://localhost:4200/");
		driver.findElement(By.xpath("/html/body/app-root/app-header/header/nav/ul/li[9]/a")).click();
		driver.findElement(By.id("email")).sendKeys("jonatasdos@outlook.com");
		driver.findElement(By.id("password")).sendKeys("1234567");
		//driver.manage().timeouts().implicitlyWait(5, TimeUnit.SECONDS)
		driver.findElement(By.id("password")).sendKeys(Keys.ENTER);
		
	}

	@Test
	public void TesteLoginSucesso() {
		driver.get("http://localhost:4200/");
		driver.findElement(By.xpath("/html/body/app-root/app-header/header/nav/ul/li[9]/a")).click();
		driver.findElement(By.id("email")).sendKeys("jonatasdos@outlook.com");
		driver.findElement(By.id("password")).sendKeys("123456");
		//driver.manage().timeouts().implicitlyWait(5, TimeUnit.SECONDS)
		driver.findElement(By.id("password")).sendKeys(Keys.ENTER);
		
	}
	
	@Test
	public void TesteLoginEmailRequered() {
		driver.get("http://localhost:4200/");
		driver.findElement(By.xpath("/html/body/app-root/app-header/header/nav/ul/li[9]/a")).click();
		driver.findElement(By.id("email")).sendKeys("");
		driver.findElement(By.id("password")).sendKeys("123456");
		//driver.manage().timeouts().implicitlyWait(5, TimeUnit.SECONDS)
		driver.findElement(By.id("password")).sendKeys(Keys.ENTER);
		
	}
	
	@Test
	public void TesteLoginPasswordRequered() {
		driver.get("http://localhost:4200/");
		driver.findElement(By.xpath("/html/body/app-root/app-header/header/nav/ul/li[9]/a")).click();
		driver.findElement(By.id("email")).sendKeys("");
		driver.findElement(By.id("password")).sendKeys("123456");
		//driver.manage().timeouts().implicitlyWait(5, TimeUnit.SECONDS)
		driver.findElement(By.id("password")).sendKeys(Keys.ENTER);
		
	}
	
	@Test
	public void TesteLoginEmailIncorrect() {
		driver.get("http://localhost:4200/");
		driver.findElement(By.xpath("/html/body/app-root/app-header/header/nav/ul/li[9]/a")).click();
		driver.findElement(By.id("email")).sendKeys("adriano@gmail.com");
		driver.findElement(By.id("password")).sendKeys("123456");
		//driver.manage().timeouts().implicitlyWait(5, TimeUnit.SECONDS)
		driver.findElement(By.id("password")).sendKeys(Keys.ENTER);
	}
	
	//final
	@After
	public void FinalLogin() {
		 driver.quit();
	}

	
}



