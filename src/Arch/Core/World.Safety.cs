namespace Arch.Core;

public partial class World
{
    public bool ThrowOnStructuralChanges { get; set; }

    public void ThrowIfStructuralChanges()
    {
        if (ThrowOnStructuralChanges)
        {
            throw new InvalidOperationException("Structural changes are not allowed in this context.");
        }
    }
}
