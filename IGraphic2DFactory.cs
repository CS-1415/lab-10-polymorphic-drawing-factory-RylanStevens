namespace Lab10DrawingApp
{
    public interface IGraphic2DFactory
    {
        string Name { get; } 
        IGraphic2D Create();
    }
}