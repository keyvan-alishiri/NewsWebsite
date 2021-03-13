﻿using AutoMapper;
using NewsWebsite.Data.Contracts;
using NewsWebsite.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsWebsite.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        public NewsDBContext _Context { get; }
        private IMapper _mapper;
        private ICategoryRepository _categoryRepository;
        private ITagRepository _tagRepository;
        private IVideoRepository _videoRepository;
        private INewsRepository _newsRepository;

        public UnitOfWork(NewsDBContext context, IMapper mapper)
        {
            _Context = context;
            _mapper = mapper;
        }

        public IBaseRepository<TEntity> BaseRepository<TEntity>() where TEntity : class
        {
            IBaseRepository<TEntity> repository = new BaseRepository<TEntity,NewsDBContext>(_Context);
            return repository;
        }

        public ICategoryRepository CategoryRepository
        {
            get
            {
                if (_categoryRepository == null)
                    _categoryRepository = new CategoryRepository(_Context,_mapper);

                return _categoryRepository;
            }
        }

        public ITagRepository TagRepository
        {
            get
            {
                if (_tagRepository == null)
                    _tagRepository = new TagRepository(_Context);

                return _tagRepository;
            }
        }


        public IVideoRepository VideoRepository
        {
            get
            {
                if (_videoRepository == null)
                    _videoRepository = new VideoRepository(_Context);

                return _videoRepository;
            }
        }

        public INewsRepository NewsRepository
        {
            get
            {
                if (_newsRepository == null)
                    _newsRepository = new NewsRepository(_Context, _mapper);

                return _newsRepository;
            }
        }


        public async Task Commit()
        {
            await _Context.SaveChangesAsync();
        }
    }
}
