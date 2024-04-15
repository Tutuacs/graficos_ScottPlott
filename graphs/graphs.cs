public class GraphService
{
    public byte[] Graph1()
    {
        double[] dataX = { 1, 2, 3, 4, 5 };
        double[] dataY = { 2, 4, 6, 8, 10 };

        // Criando o gráfico de linha com ScottPlot
        var plt = new ScottPlot.Plot(600, 400);
        var scatter = plt.AddScatter(dataX, dataY);
        var scatter2 = plt.AddScatter(dataY, dataX);
        scatter.MarkerSize = 5;
        scatter2.MarkerSize = 5;
        scatter.LineWidth = 2;
        scatter2.LineWidth = 2;
        plt.Title("Gráfico de Linha de Exemplo");
        plt.XLabel("Eixo X");
        plt.YLabel("Eixo Y");

        // Convertendo o gráfico em uma imagem e retornando como um array de bytes
        using MemoryStream ms = new();
        plt.GetBitmap().Save(ms, System.Drawing.Imaging.ImageFormat.Png);
        return ms.ToArray();
    }

    public void Graph2()
    {
        // Implementação da função 2
    }

    public void Graph3()
    {
        // Implementação da função 3
    }

    public void Graph4()
    {
        // Implementação da função 4
    }

}