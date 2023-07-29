using Microsoft.EntityFrameworkCore;
using MTS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTS.Persistence.DatabaseContext;

public class MtstestContext :DbContext
{

    public MtstestContext(DbContextOptions<MtstestContext> options)
        : base(options)
    {
    }


    public virtual DbSet<TblUsermaster> TblUsermaster { get; set; }
    public virtual DbSet<TblMenu> TblMenu { get; set; } 
    public virtual DbSet<TblQuarantine> TblQuarantine { get; set; }
    public virtual DbSet<TblCalibrationFrequency> TblCalibrationFrequency { get; set;}
    public virtual DbSet<TblCalibrationWeights> TblCalibrationWeights { get; set;}

}
