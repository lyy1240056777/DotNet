using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TodoApi.Models;

namespace TodoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoItemsController : ControllerBase
    {
        private readonly TodoContext _context;

        public TodoItemsController(TodoContext context)
        {
            _context = context;
        }

        // GET: api/TodoItems
        [HttpGet]
        /*
        public async Task<ActionResult<IEnumerable<TodoItem>>> GetTodoItems()
        {
            return await _context.TodoItems.ToListAsync();
        }
        */
        public ActionResult<List<TodoItem>> GetTodoItems(string name,bool? isComplete)
        {
            IQueryable<TodoItem> query = _context.TodoItems;
            if (name != null)
            {
                query = query.Where(t => t.Name.Contains(name));
            }
            if (isComplete != null)
            {
                query = query.Where(t => t.IsComplete == isComplete);
            }
            return query.ToList();
        }

        // GET: api/TodoItems/5
        [HttpGet("{id}")]
        /*
        public async Task<ActionResult<TodoItem>> GetTodoItem(long id)
        {
            var todoItem = await _context.TodoItems.FindAsync(id);

            if (todoItem == null)
            {
                return NotFound();
            }

            return todoItem;
        }
        */
        public ActionResult<TodoItem> GetTodoItem(long id)
        {
            var todoItem = _context.TodoItems.FirstOrDefault(t => t.Id == id);
            if (todoItem == null)
            {
                return NotFound();
            }
            return todoItem;
        }

        // PUT: api/TodoItems/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        /*
        public async Task<IActionResult> PutTodoItem(long id, TodoItem todoItem)
        {
            if (id != todoItem.Id)
            {
                return BadRequest();
            }

            _context.Entry(todoItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TodoItemExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }
        */
        public ActionResult<TodoItem> PutTodoItem(long id, TodoItem todo)
        {
            if (id != todo.Id)
            {
                return BadRequest("Id cannot be modified!");
            }
            try
            {
                _context.Entry(todo).State = EntityState.Modified;
                _context.SaveChanges();
            }catch(Exception e)
            {
                string error = e.Message;
                if (e.InnerException != null) error = e.InnerException.Message;
                return BadRequest(error);
            }
            return NoContent();
        }

        // POST: api/TodoItems
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        /*
        public async Task<ActionResult<TodoItem>> PostTodoItem(TodoItem todoItem)
        {
            _context.TodoItems.Add(todoItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetTodoItem), new { id = todoItem.Id }, todoItem);
        }
        */
        public ActionResult<TodoItem> PostTodoItem(TodoItem todo)
        {
            try
            {
                _context.TodoItems.Add(todo);
                _context.SaveChanges();
            }catch(Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return todo;
        }

        // DELETE: api/TodoItems/5
        [HttpDelete("{id}")]
        /*
        public async Task<ActionResult<TodoItem>> DeleteTodoItem(long id)
        {
            var todoItem = await _context.TodoItems.FindAsync(id);
            if (todoItem == null)
            {
                return NotFound();
            }

            _context.TodoItems.Remove(todoItem);
            await _context.SaveChangesAsync();

            return todoItem;
        }
        */
        public ActionResult DeleteTodoItem(long id)
        {
            try
            {
                var todo = _context.TodoItems.FirstOrDefault(t => t.Id == id);
                if (todo != null)
                {
                    _context.Remove(todo);
                    _context.SaveChanges();
                }
            }catch(Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return NoContent();
        }

        private bool TodoItemExists(long id)
        {
            return _context.TodoItems.Any(e => e.Id == id);
        }
    }
}
