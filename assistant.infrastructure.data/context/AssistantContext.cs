using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assistant.infrastructure.data.context
{
    public class AssistantContext : DbContext
    {
        public AssistantContext(DbContextOptions<AssistantContext> options) : base(options) { }
    }
}
