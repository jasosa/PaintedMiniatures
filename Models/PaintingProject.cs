using MiniaturesApp.Models;

public interface PaintingProject    
{
    string Name { get; set; }
    string CoverImageUrl { get; set; }
    List<Miniature> Miniatures { get; set; }
    double PaintedPercentage { get; }
    string ProjectType { get; }
}