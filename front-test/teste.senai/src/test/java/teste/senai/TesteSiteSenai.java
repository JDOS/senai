package teste.senai;

import org.junit.After;
import org.junit.Before;
import org.junit.Test;
import org.openqa.selenium.By;
import org.openqa.selenium.Keys;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.chrome.ChromeDriver;

public class TesteSiteSenai {

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
public void TesteNavegabilidade() {
	driver.get("https://sp.senai.br/unidade/informatica/");
	driver.findElement(By.id("s1")).sendKeys("Excel");
	driver.findElement(By.id("s1")).sendKeys(Keys.ENTER);
	
}
	
//final
//@After

}