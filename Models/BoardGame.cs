namespace MiniaturesApp.Models;

public class BoardGame : PaintingProject
{
    public string Name { get; set; } = "";
    public string CoverImageUrl { get; set; } = "";
    public List<Miniature> Miniatures { get; set; } = new();

    public double PaintedPercentage =>
        Miniatures.Count == 0 ? 0 :
        (double)Miniatures.Count(m => m.IsPainted) / Miniatures.Count * 100;

    public string ProjectType { get => "Board Game"; }
}
