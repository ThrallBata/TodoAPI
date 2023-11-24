using Microsoft.EntityFrameworkCore;

public class EFTodoDBContext: DbContext
{   
    public EFTodoDBContext(DbContextOptions<EFTodoDBContext> options) : base(options) 
    { }   
    public DbSet<TodoItem> TodoItems { get; set; }
 }
 