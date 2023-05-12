using ItGeek.BLL.Repositories;
using ItGeek.DAL.Data;

namespace ItGeek.BLL;

public class UnitOfWork
{
    private readonly AppDbContext _db;

    public UnitOfWork(AppDbContext db)
	{
        _db = db;
    }

    private AuthorRepository _authorRepository;
    private CategoryRepository _categoryRepository;
    private CommentRepository _commentRepository;
    private PostRepository _postRepository;
    private RoleRepository _roleRepository;
    private TagRepository _tagRepository;
    private UserRepository _userRepository;

    public AuthorRepository AuthorRepository { get { if (_authorRepository == null) { _authorRepository = new AuthorRepository(_db); } return _authorRepository; } }
    public CategoryRepository CategoryRepository { get { if (_categoryRepository == null) { _categoryRepository = new CategoryRepository(_db); } return _categoryRepository; } }
    public CommentRepository CommentRepository { get { if (_commentRepository == null) { _commentRepository = new CommentRepository(_db); } return _commentRepository; } }
    public PostRepository PostRepository { get { if (_postRepository == null) { _postRepository = new PostRepository(_db); } return _postRepository; } }
    public RoleRepository RoleRepository { get { if (_roleRepository == null) { _roleRepository = new RoleRepository(_db); } return _roleRepository; } }
    public TagRepository TagRepository { get { if (_tagRepository == null) { _tagRepository = new TagRepository(_db); } return _tagRepository; } }
    public UserRepository UserRepository { get { if (_userRepository == null) { _userRepository = new UserRepository(_db); } return _userRepository; } }
}
