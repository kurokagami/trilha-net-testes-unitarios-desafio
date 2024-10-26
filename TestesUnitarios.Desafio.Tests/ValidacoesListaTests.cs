using TestesUnitarios.Desafio.Console.Services;

namespace TestesUnitarios.Desafio.Tests;

public class ValidacoesListaTests
{
    private ValidacoesLista _validacoes = new ValidacoesLista();

    [Fact]
    public void DeveRemoverNumerosNegativosDeUmaLista()
    {
        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };
        var resultadoEsperado = new List<int> { 5, 9 };

        // Act
        var resultado = _validacoes.RemoverNumerosNegativos(lista);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void DeveConterONumero9NaLista()
    {
        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };
        var numeroParaProcurar = 9;

        // Act
        var resultado = _validacoes.ListaContemDeterminadoNumero(lista, numeroParaProcurar);

        // Assert
        Assert.True(resultado);
    }

    [Fact]
    public void NaoDeveConterONumero10NaLista()
    {
        //DONE: Implementado método de teste

        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };
        var numeroParaProcurar = 10;

        // Act
        var result = lista.Contains(numeroParaProcurar);
        // Assert
        Assert.False(result);
    }

    //DONE: Corrigido a anotação [Fact]
    [Fact]
    public void DeveMultiplicarOsElementosDaListaPor2()
    {
        //DONE: Implementado método de teste

        // Arrange
        var lista = new List<int> { 5, 7, 8, 9 };
        var resultadoEsperado = new List<int> { 10, 14, 16, 18 };
        
        // Act
        var result = lista.Select(x => x * 2).ToList();

        // Assert
        Assert.Equal(resultadoEsperado, result);
    }

    [Fact]
    public void DeveRetornar9ComoMaiorNumeroDaLista()
    {
        //DONE: Implementado método de teste

        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };

        // Act
        var result = _validacoes.RetornarMaiorNumeroLista(lista);

        // Assert
        //DONE: Corrigido o Assert.Equal com base no retorno da chamada ao método
        Assert.Equal(9, result);
    }

    [Fact]
    public void DeveRetornarOitoNegativoComoMenorNumeroDaLista()
    {
        //DONE: Implementado método de teste

        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };

        // Act
        var result = _validacoes.RetornarMenorNumeroLista(lista);

        // Assert
        //DONE: Corrigido o Assert.Equal com base no retorno da chamada ao método
        Assert.Equal(-8, result);
    }
}
