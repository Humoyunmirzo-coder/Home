﻿using Aplication.Service;
using Domain.Entitys.Home.Services;
using Domain.Model;
using Infrastructure.DataAccess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Service
{
    public class HomeBuildService : IHomeBuild
    {
        private readonly HomeDbContext _homeDbContext;

       

        public async Task<Response<HomeBuild>> CreateHomeBuildAynce(HomeBuild homeBuild)
        {
            try
            {
                await _homeDbContext.HomeBuilds.AddAsync(homeBuild);
                await _homeDbContext.SaveChangesAsync();
                return new Response<HomeBuild>(homeBuild);
            }
            catch (Exception ex)
            {
                return new Response<HomeBuild>("Failed to create homeBuild: " + ex.Message);
            }
        }

        public async Task<Response<bool>> DeleteHomeBuildAynce(int Id)
        {
            var homebuild = await _homeDbContext.HomeBuilds.FindAsync(Id);
            if (homebuild == null)
            {
                return new Response<bool>("Home build not found.");
            }

            try
            {
                _homeDbContext.HomeBuilds.Remove(homebuild);
                await _homeDbContext.SaveChangesAsync();
                return new Response<bool>("Home build deleted successfully.");
            }
            catch (Exception ex)
            {
                return new Response<bool>("Failed to delete Home build: " + ex.Message);
            }
        }

        public async Task<Response<List<HomeBuild>>> GetAllHomeBuildAynce()
        {
            try
            {
                var homeBuild = await _homeDbContext.HomeBuilds.ToListAsync();

                return new Response<List<HomeBuild>>(homeBuild);
            }
            catch (Exception ex)
            {
                return new Response<List<HomeBuild>>("Failed to get all home build: " + ex.Message);
            }
        }

        public async Task<Response<HomeBuild>> GetByIdHomeBuildAynce(int Id)
        {
            try
            {
                var homeBuild = await _homeDbContext.HomeBuilds.FindAsync(Id);

                if (homeBuild == null)
                {
                    return new Response<HomeBuild>(" Home Build  not found.");
                }

                return new Response<HomeBuild>(homeBuild);
            }
            catch (Exception ex)
            {
                return new Response<HomeBuild>("Failed to get  home build : " + ex.Message);
            }
        }


        public async Task<Response<HomeBuild>> UpdateHomeBuildAynce(HomeBuild homeBuild)
        {
            try
            {
                _homeDbContext.HomeBuilds.Update(homeBuild);
                await _homeDbContext.SaveChangesAsync();
                return new Response<HomeBuild>(homeBuild);
            }
            catch (Exception ex)
            {
                return new Response<HomeBuild>("Failed to update home build : " + ex.Message);
            }
        }
    }
}
