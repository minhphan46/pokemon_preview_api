using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PokemonPreview.Data;
using PokemonPreview.Interfaces;
using PokemonPreview.Models;

namespace PokemonPreview.Repository
{
    public class ReviewerRepository : IReviewerRepository
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public ReviewerRepository(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public bool CreateReviewer(Reviewer reviewer)
        {
            throw new NotImplementedException();
        }

        public bool DeleteReviewer(Reviewer reviewer)
        {
            throw new NotImplementedException();
        }

        public Reviewer GetReviewer(int reviewerId)
        {
            return _context.Reviewers.Where(r => r.Id == reviewerId).Include(e => e.Reviews).FirstOrDefault();
        }

        public ICollection<Reviewer> GetReviewers()
        {
            return _context.Reviewers.ToList();
        }

        public ICollection<Review> GetReviewsByReviewer(int reviewerId)
        {
            return _context.Reviews.Where(r => r.Reviewer.Id == reviewerId).ToList();
        }

        public bool ReviewerExists(int reviewerId)
        {
            return _context.Reviewers.Any(r => r.Id == reviewerId);
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }

        public bool UpdateReviewer(Reviewer reviewer)
        {
            throw new NotImplementedException();
        }
    }
}
