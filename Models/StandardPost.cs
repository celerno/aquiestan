using Piranha.AttributeBuilder;
using Piranha.Models;

namespace aquiestan.org.Models
{
    [PostType(Title = "Standard post")]
    public class StandardPost  : Post<StandardPost>
    {
    }
}