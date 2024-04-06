using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests;

[TestClass()]
public class SoftwareUsageTests
{
    [TestMethod()]
    [DataRow(int.MinValue, false)]
    [DataRow(-1, false)]
    [DataRow(0, false)]
    [DataRow(1, false)]
    [DataRow(17, false)]
    [DataRow(18, true)]
    [DataRow(int.MaxValue, true)]
    public void MaiorDeIdadeTest(int idade, bool maiorDeIdade)
    {
        // Arrange.
        var serviço = new SoftwareUsage();
        var profile = new Profile { Nome = "Pedro", Idade = idade, Endereço = "Av Atlântica, 9911" };

        // Act.
        var resultado = serviço.MaiorDeIdade(profile);

        // Assert.
        Assert.AreEqual(maiorDeIdade, resultado, "Não foi possível.");
    }

    [TestMethod()]
    [DataRow(int.MinValue, false)]
    [DataRow(-1, false)]
    [DataRow(0, false)]
    [DataRow(1, false)]
    [DataRow(17, false)]
    [DataRow(18, true)]
    [DataRow(int.MaxValue, true)]
    public void ResumoTest(string nome, string endereço, int idade, string resumo)
    {
        // Arrange.
        var serviço = new SoftwareUsage();
        var profile = new Profile { Nome = nome, Idade = idade, Endereço = endereço };

        // Act.
        var resultado = serviço.Resumo(profile);

        // Assert.
        Assert.AreEqual(resumo, resultado, "Não foi possível.");
    }
}