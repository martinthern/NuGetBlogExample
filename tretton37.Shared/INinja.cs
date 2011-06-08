using System.Collections.Generic;

namespace tretton37.Shared
{
    public interface INinja
    {
        IEnumerable<string> MadSkillz { get; }
        IEnumerable<string> Weapons { get; }
    }
}
