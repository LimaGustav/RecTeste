namespace RecTestBack;

public class UnitTest1
{
    [Fact]
    public void SomaCalculadora()
    {
        //Preparar 
        int soma = 10+25; // 35

        //Testar - Utilizar a ferramenta que estamos testando
        int calculadoraSoma = Calculadora.Soma(10,25);

        //Validar o resultado
        Assert.Equal(soma, calculadoraSoma);
    }

    [Fact]
    public void FiltraNomes()
    {
        //Preparar
        List<string> NomesCriados = new List<string>(); // Cria a lista
        NomesCriados.Add("Gustavo Lima");
        NomesCriados.Add("Kleber Ferraz");
        NomesCriados.Add("Lucas Simionato");
        NomesCriados.Add("Guilherme Dantas");

        //Utilizar a ferramenta que estamos testando
        Filtro filtro = new Filtro(); // Nosso filtro onde nos escolhemos o nome dele

        int qtdNome = filtro.FiltrarNome(NomesCriados);
        
        //Validar o resultado
        Assert.Equal(qtdNome,2);
    }
}