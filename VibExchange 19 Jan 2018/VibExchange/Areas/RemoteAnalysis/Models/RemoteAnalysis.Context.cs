﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VibExchange.Areas.RemoteAnalysis.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class Iadept_CloudEntities : DbContext
    {
        public Iadept_CloudEntities()
            : base("name=Iadept_CloudEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tblAlarm> tblAlarms { get; set; }
        public virtual DbSet<tblArea> tblAreas { get; set; }
        public virtual DbSet<tblBearing> tblBearings { get; set; }
        public virtual DbSet<tblFaultFrequency> tblFaultFrequencies { get; set; }
        public virtual DbSet<tblFileData> tblFileDatas { get; set; }
        public virtual DbSet<tblInstrument> tblInstruments { get; set; }
        public virtual DbSet<tblJob> tblJobs { get; set; }
        public virtual DbSet<tblMachine> tblMachines { get; set; }
        public virtual DbSet<tblMeasure_Benstone> tblMeasure_Benstone { get; set; }
        public virtual DbSet<tblMeasurementSetup_Benstone> tblMeasurementSetup_Benstone { get; set; }
        public virtual DbSet<tblMeasurementSetup_Kohtect> tblMeasurementSetup_Kohtect { get; set; }
        public virtual DbSet<tblPlant> tblPlants { get; set; }
        public virtual DbSet<tblPoint> tblPoints { get; set; }
        public virtual DbSet<tblPointData_Kohtect> tblPointData_Kohtect { get; set; }
        public virtual DbSet<tblSensor> tblSensors { get; set; }
        public virtual DbSet<tblTrain> tblTrains { get; set; }
        public virtual DbSet<tblUnit> tblUnits { get; set; }
        public virtual DbSet<tblUserMaster> tblUserMasters { get; set; }
    
        public virtual int AddArea(Nullable<int> fileID, string areaName, string areaDeatil, Nullable<int> parentID, string parentType, ObjectParameter areaID)
        {
            var fileIDParameter = fileID.HasValue ?
                new ObjectParameter("FileID", fileID) :
                new ObjectParameter("FileID", typeof(int));
    
            var areaNameParameter = areaName != null ?
                new ObjectParameter("AreaName", areaName) :
                new ObjectParameter("AreaName", typeof(string));
    
            var areaDeatilParameter = areaDeatil != null ?
                new ObjectParameter("AreaDeatil", areaDeatil) :
                new ObjectParameter("AreaDeatil", typeof(string));
    
            var parentIDParameter = parentID.HasValue ?
                new ObjectParameter("ParentID", parentID) :
                new ObjectParameter("ParentID", typeof(int));
    
            var parentTypeParameter = parentType != null ?
                new ObjectParameter("ParentType", parentType) :
                new ObjectParameter("ParentType", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddArea", fileIDParameter, areaNameParameter, areaDeatilParameter, parentIDParameter, parentTypeParameter, areaID);
        }
    
        public virtual int AddMachine(Nullable<int> fileID, string machineName, string machineDeatil, string machineClass, Nullable<int> rPMDriven, Nullable<int> pulseRevolution, Nullable<int> parentID, string parentType, ObjectParameter machineID)
        {
            var fileIDParameter = fileID.HasValue ?
                new ObjectParameter("FileID", fileID) :
                new ObjectParameter("FileID", typeof(int));
    
            var machineNameParameter = machineName != null ?
                new ObjectParameter("MachineName", machineName) :
                new ObjectParameter("MachineName", typeof(string));
    
            var machineDeatilParameter = machineDeatil != null ?
                new ObjectParameter("MachineDeatil", machineDeatil) :
                new ObjectParameter("MachineDeatil", typeof(string));
    
            var machineClassParameter = machineClass != null ?
                new ObjectParameter("MachineClass", machineClass) :
                new ObjectParameter("MachineClass", typeof(string));
    
            var rPMDrivenParameter = rPMDriven.HasValue ?
                new ObjectParameter("RPMDriven", rPMDriven) :
                new ObjectParameter("RPMDriven", typeof(int));
    
            var pulseRevolutionParameter = pulseRevolution.HasValue ?
                new ObjectParameter("PulseRevolution", pulseRevolution) :
                new ObjectParameter("PulseRevolution", typeof(int));
    
            var parentIDParameter = parentID.HasValue ?
                new ObjectParameter("ParentID", parentID) :
                new ObjectParameter("ParentID", typeof(int));
    
            var parentTypeParameter = parentType != null ?
                new ObjectParameter("ParentType", parentType) :
                new ObjectParameter("ParentType", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddMachine", fileIDParameter, machineNameParameter, machineDeatilParameter, machineClassParameter, rPMDrivenParameter, pulseRevolutionParameter, parentIDParameter, parentTypeParameter, machineID);
        }
    
        public virtual int AddPlant(Nullable<int> fileID, string plantName, string category, string plantDetail, ObjectParameter plantID)
        {
            var fileIDParameter = fileID.HasValue ?
                new ObjectParameter("FileID", fileID) :
                new ObjectParameter("FileID", typeof(int));
    
            var plantNameParameter = plantName != null ?
                new ObjectParameter("PlantName", plantName) :
                new ObjectParameter("PlantName", typeof(string));
    
            var categoryParameter = category != null ?
                new ObjectParameter("Category", category) :
                new ObjectParameter("Category", typeof(string));
    
            var plantDetailParameter = plantDetail != null ?
                new ObjectParameter("PlantDetail", plantDetail) :
                new ObjectParameter("PlantDetail", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddPlant", fileIDParameter, plantNameParameter, categoryParameter, plantDetailParameter, plantID);
        }
    
        public virtual int AddPoint(Nullable<int> fileID, string pointName, string pointDeatil, Nullable<int> bearingID, Nullable<int> parentID, string parentType, ObjectParameter pointID)
        {
            var fileIDParameter = fileID.HasValue ?
                new ObjectParameter("FileID", fileID) :
                new ObjectParameter("FileID", typeof(int));
    
            var pointNameParameter = pointName != null ?
                new ObjectParameter("PointName", pointName) :
                new ObjectParameter("PointName", typeof(string));
    
            var pointDeatilParameter = pointDeatil != null ?
                new ObjectParameter("PointDeatil", pointDeatil) :
                new ObjectParameter("PointDeatil", typeof(string));
    
            var bearingIDParameter = bearingID.HasValue ?
                new ObjectParameter("BearingID", bearingID) :
                new ObjectParameter("BearingID", typeof(int));
    
            var parentIDParameter = parentID.HasValue ?
                new ObjectParameter("ParentID", parentID) :
                new ObjectParameter("ParentID", typeof(int));
    
            var parentTypeParameter = parentType != null ?
                new ObjectParameter("ParentType", parentType) :
                new ObjectParameter("ParentType", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddPoint", fileIDParameter, pointNameParameter, pointDeatilParameter, bearingIDParameter, parentIDParameter, parentTypeParameter, pointID);
        }
    
        public virtual int addRecordedDataForKohtect(Nullable<int> fileid, string userid, Nullable<int> alarmid, Nullable<int> chnl1, Nullable<int> radio1, Nullable<int> chnl2, Nullable<int> radio2, Nullable<int> eVfreq, Nullable<int> sLine, Nullable<int> wType, Nullable<int> fmin, Nullable<int> fmax, Nullable<int> tMode, Nullable<int> aMode, Nullable<int> n, string comment, Nullable<int> pointID, Nullable<System.DateTime> mTime, Nullable<double> overallValue, string ovUnit, string chnl1FFTX, string chnl1FFTY, string chnl2FFTX, string chnl2FFTY)
        {
            var fileidParameter = fileid.HasValue ?
                new ObjectParameter("Fileid", fileid) :
                new ObjectParameter("Fileid", typeof(int));
    
            var useridParameter = userid != null ?
                new ObjectParameter("Userid", userid) :
                new ObjectParameter("Userid", typeof(string));
    
            var alarmidParameter = alarmid.HasValue ?
                new ObjectParameter("Alarmid", alarmid) :
                new ObjectParameter("Alarmid", typeof(int));
    
            var chnl1Parameter = chnl1.HasValue ?
                new ObjectParameter("Chnl1", chnl1) :
                new ObjectParameter("Chnl1", typeof(int));
    
            var radio1Parameter = radio1.HasValue ?
                new ObjectParameter("Radio1", radio1) :
                new ObjectParameter("Radio1", typeof(int));
    
            var chnl2Parameter = chnl2.HasValue ?
                new ObjectParameter("Chnl2", chnl2) :
                new ObjectParameter("Chnl2", typeof(int));
    
            var radio2Parameter = radio2.HasValue ?
                new ObjectParameter("Radio2", radio2) :
                new ObjectParameter("Radio2", typeof(int));
    
            var eVfreqParameter = eVfreq.HasValue ?
                new ObjectParameter("EVfreq", eVfreq) :
                new ObjectParameter("EVfreq", typeof(int));
    
            var sLineParameter = sLine.HasValue ?
                new ObjectParameter("SLine", sLine) :
                new ObjectParameter("SLine", typeof(int));
    
            var wTypeParameter = wType.HasValue ?
                new ObjectParameter("WType", wType) :
                new ObjectParameter("WType", typeof(int));
    
            var fminParameter = fmin.HasValue ?
                new ObjectParameter("Fmin", fmin) :
                new ObjectParameter("Fmin", typeof(int));
    
            var fmaxParameter = fmax.HasValue ?
                new ObjectParameter("Fmax", fmax) :
                new ObjectParameter("Fmax", typeof(int));
    
            var tModeParameter = tMode.HasValue ?
                new ObjectParameter("TMode", tMode) :
                new ObjectParameter("TMode", typeof(int));
    
            var aModeParameter = aMode.HasValue ?
                new ObjectParameter("AMode", aMode) :
                new ObjectParameter("AMode", typeof(int));
    
            var nParameter = n.HasValue ?
                new ObjectParameter("N", n) :
                new ObjectParameter("N", typeof(int));
    
            var commentParameter = comment != null ?
                new ObjectParameter("Comment", comment) :
                new ObjectParameter("Comment", typeof(string));
    
            var pointIDParameter = pointID.HasValue ?
                new ObjectParameter("PointID", pointID) :
                new ObjectParameter("PointID", typeof(int));
    
            var mTimeParameter = mTime.HasValue ?
                new ObjectParameter("MTime", mTime) :
                new ObjectParameter("MTime", typeof(System.DateTime));
    
            var overallValueParameter = overallValue.HasValue ?
                new ObjectParameter("OverallValue", overallValue) :
                new ObjectParameter("OverallValue", typeof(double));
    
            var ovUnitParameter = ovUnit != null ?
                new ObjectParameter("OvUnit", ovUnit) :
                new ObjectParameter("OvUnit", typeof(string));
    
            var chnl1FFTXParameter = chnl1FFTX != null ?
                new ObjectParameter("Chnl1FFTX", chnl1FFTX) :
                new ObjectParameter("Chnl1FFTX", typeof(string));
    
            var chnl1FFTYParameter = chnl1FFTY != null ?
                new ObjectParameter("Chnl1FFTY", chnl1FFTY) :
                new ObjectParameter("Chnl1FFTY", typeof(string));
    
            var chnl2FFTXParameter = chnl2FFTX != null ?
                new ObjectParameter("Chnl2FFTX", chnl2FFTX) :
                new ObjectParameter("Chnl2FFTX", typeof(string));
    
            var chnl2FFTYParameter = chnl2FFTY != null ?
                new ObjectParameter("Chnl2FFTY", chnl2FFTY) :
                new ObjectParameter("Chnl2FFTY", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("addRecordedDataForKohtect", fileidParameter, useridParameter, alarmidParameter, chnl1Parameter, radio1Parameter, chnl2Parameter, radio2Parameter, eVfreqParameter, sLineParameter, wTypeParameter, fminParameter, fmaxParameter, tModeParameter, aModeParameter, nParameter, commentParameter, pointIDParameter, mTimeParameter, overallValueParameter, ovUnitParameter, chnl1FFTXParameter, chnl1FFTYParameter, chnl2FFTXParameter, chnl2FFTYParameter);
        }
    
        public virtual int AddTrain(Nullable<int> fileID, string trainName, string trainDeatil, Nullable<int> noofMachine, Nullable<int> parentID, string parentType, ObjectParameter trainID)
        {
            var fileIDParameter = fileID.HasValue ?
                new ObjectParameter("FileID", fileID) :
                new ObjectParameter("FileID", typeof(int));
    
            var trainNameParameter = trainName != null ?
                new ObjectParameter("TrainName", trainName) :
                new ObjectParameter("TrainName", typeof(string));
    
            var trainDeatilParameter = trainDeatil != null ?
                new ObjectParameter("TrainDeatil", trainDeatil) :
                new ObjectParameter("TrainDeatil", typeof(string));
    
            var noofMachineParameter = noofMachine.HasValue ?
                new ObjectParameter("NoofMachine", noofMachine) :
                new ObjectParameter("NoofMachine", typeof(int));
    
            var parentIDParameter = parentID.HasValue ?
                new ObjectParameter("ParentID", parentID) :
                new ObjectParameter("ParentID", typeof(int));
    
            var parentTypeParameter = parentType != null ?
                new ObjectParameter("ParentType", parentType) :
                new ObjectParameter("ParentType", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddTrain", fileIDParameter, trainNameParameter, trainDeatilParameter, noofMachineParameter, parentIDParameter, parentTypeParameter, trainID);
        }
    
        public virtual int addUploadDataRAM(string userID, string fileName, string fileType, string fileFormate, string instrumentUsed, Nullable<int> noOfMachines, Nullable<int> noOfPoints, string analysisMethod, string imagePath, string description, ObjectParameter id)
        {
            var userIDParameter = userID != null ?
                new ObjectParameter("UserID", userID) :
                new ObjectParameter("UserID", typeof(string));
    
            var fileNameParameter = fileName != null ?
                new ObjectParameter("FileName", fileName) :
                new ObjectParameter("FileName", typeof(string));
    
            var fileTypeParameter = fileType != null ?
                new ObjectParameter("FileType", fileType) :
                new ObjectParameter("FileType", typeof(string));
    
            var fileFormateParameter = fileFormate != null ?
                new ObjectParameter("FileFormate", fileFormate) :
                new ObjectParameter("FileFormate", typeof(string));
    
            var instrumentUsedParameter = instrumentUsed != null ?
                new ObjectParameter("InstrumentUsed", instrumentUsed) :
                new ObjectParameter("InstrumentUsed", typeof(string));
    
            var noOfMachinesParameter = noOfMachines.HasValue ?
                new ObjectParameter("NoOfMachines", noOfMachines) :
                new ObjectParameter("NoOfMachines", typeof(int));
    
            var noOfPointsParameter = noOfPoints.HasValue ?
                new ObjectParameter("NoOfPoints", noOfPoints) :
                new ObjectParameter("NoOfPoints", typeof(int));
    
            var analysisMethodParameter = analysisMethod != null ?
                new ObjectParameter("AnalysisMethod", analysisMethod) :
                new ObjectParameter("AnalysisMethod", typeof(string));
    
            var imagePathParameter = imagePath != null ?
                new ObjectParameter("ImagePath", imagePath) :
                new ObjectParameter("ImagePath", typeof(string));
    
            var descriptionParameter = description != null ?
                new ObjectParameter("Description", description) :
                new ObjectParameter("Description", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("addUploadDataRAM", userIDParameter, fileNameParameter, fileTypeParameter, fileFormateParameter, instrumentUsedParameter, noOfMachinesParameter, noOfPointsParameter, analysisMethodParameter, imagePathParameter, descriptionParameter, id);
        }
    
        public virtual int GetFilePathbyFileID(Nullable<int> fileID, string userID, ObjectParameter filePath)
        {
            var fileIDParameter = fileID.HasValue ?
                new ObjectParameter("FileID", fileID) :
                new ObjectParameter("FileID", typeof(int));
    
            var userIDParameter = userID != null ?
                new ObjectParameter("UserID", userID) :
                new ObjectParameter("UserID", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("GetFilePathbyFileID", fileIDParameter, userIDParameter, filePath);
        }
    
        public virtual ObjectResult<GetHierarchyData_Result> GetHierarchyData(Nullable<int> fileID)
        {
            var fileIDParameter = fileID.HasValue ?
                new ObjectParameter("FileID", fileID) :
                new ObjectParameter("FileID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetHierarchyData_Result>("GetHierarchyData", fileIDParameter);
        }
    }
}