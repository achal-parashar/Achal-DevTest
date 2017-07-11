//---------------------------------------------------------------------
// Author: Amarendra
// Version: 1.0.0
// Date: 11/01/2011
// Description:Implement Annual Report Analysis Submission Properties
//
// History:
// Changed By                       Changed On
//
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CQM.Entities
{
    /// <summary>
    /// This entity class stores the information about Annual Report Analysis Submission.
    /// </summary>
    /// <author>Amarendra</author>
    /// <creationDate>2011-11-01</ceationDate>
    /// <modifications>
    /// <item></item>
    /// <item></item>
    /// </modifications>
    public class AnalysisSubmissionEntity
    {

        #region For Water Submission
        private decimal? property;
        public decimal? Property
        {
            get { return Common.Utility.Common.Round(property); }
            set { property = value; }
        }
        private decimal? depriciation;
        public decimal? Depriciation
        {
            get { return Common.Utility.Common.Round(depriciation); }
            set { depriciation = value; }
        }
        private decimal? netIncome;
        public decimal? NetIncome
        {
            get { return Common.Utility.Common.Round(netIncome); }
            set { netIncome = value; }
        }
        private decimal? operatingRevenue;
        public decimal? OperatingRevenue
        {
            get { return Common.Utility.Common.Round(operatingRevenue); }
            set { operatingRevenue = value; }
        }
        private decimal? account403;
        public decimal? Account403
        {
            get { return Common.Utility.Common.Round(account403); }
            set { account403 = value; }
        }
        private decimal? operatingExp;
        public decimal? OperatingExp
        {
            get { return Common.Utility.Common.Round(operatingExp); }
            set { operatingExp = value; }
        }
        private decimal? numberOfResidentialCustomers;
        public decimal? NumberOfResidentialCustomers
        {
            get { return Common.Utility.Common.Round(numberOfResidentialCustomers); }
            set { numberOfResidentialCustomers = value; }
        }
        private decimal? totalCustomer;
        public decimal? TotalCustomer
        {
            get { return Common.Utility.Common.Round(totalCustomer); }
            set { totalCustomer = value; }
        }
        private decimal? totalProduction;
        public decimal? TotalProduction
        {
            get { return Common.Utility.Common.Round(totalProduction); }
            set { totalProduction = value; }
        }
        private decimal? meteredSales;
        public decimal? MeteredSales
        {
            get { return Common.Utility.Common.Round(meteredSales); }
            set { meteredSales = value; }
        }
        #endregion

        #region For TND Submission
        private decimal? numberOfCustomer;
        public decimal? NumberOfCustomer
        {
            get { return Common.Utility.Common.Round(numberOfCustomer); }
            set { numberOfCustomer = value; }
        }
        private decimal? annualSysPeak;
        public decimal? AnnualSysPeak
        {
            get { return Common.Utility.Common.Round(annualSysPeak); }
            set { annualSysPeak = value; }
        }

        private decimal? smallKwhs;
        public decimal? SmallKwhs
        {
            get { return Common.Utility.Common.Round(smallKwhs); }
            set { smallKwhs = value; }
        }
        private decimal? smallDistributionRevenue;
        public decimal? SmallDistributionRevenue
        {
            get { return Common.Utility.Common.Round(smallDistributionRevenue); }
            set { smallDistributionRevenue = value; }
        }
        private decimal? smallTransmissionRevenue;
        public decimal? SmallTransmissionRevenue
        {
            get { return Common.Utility.Common.Round(smallTransmissionRevenue); }
            set { smallTransmissionRevenue = value; }
        }
        private decimal? mediumKwhs;
        public decimal? MediumKwhs
        {
            get { return Common.Utility.Common.Round(mediumKwhs); }
            set { mediumKwhs = value; }
        }
        private decimal? mediumDistributionRevenue;
        public decimal? MediumDistributionRevenue
        {
            get { return Common.Utility.Common.Round(mediumDistributionRevenue); }
            set { mediumDistributionRevenue = value; }
        }
        private decimal? mediumTransmissionRevenue;
        public decimal? MediumTransmissionRevenue
        {
            get { return Common.Utility.Common.Round(mediumTransmissionRevenue); }
            set { mediumTransmissionRevenue = value; }
        }
        private decimal? largeKwhs;
        public decimal? LargeKwhs
        {
            get { return Common.Utility.Common.Round(largeKwhs); }
            set { largeKwhs = value; }
        }
        private decimal? largeDistributionRevenue;
        public decimal? LargeDistributionRevenue
        {
            get { return Common.Utility.Common.Round(largeDistributionRevenue); }
            set { largeDistributionRevenue = value; }
        }
        private decimal? largeTransmissionRevenue;
        public decimal? LargeTransmissionRevenue
        {
            get { return Common.Utility.Common.Round(largeTransmissionRevenue); }
            set { largeTransmissionRevenue = value; }
        }
        private string isConfidential;
        public string IsConfidential
        {
            get { return isConfidential; }
            set { isConfidential = value; }
        }
        #endregion

        #region For Elec-Cep Utility
        private decimal? smallTotalMwhSales;
        public decimal? SmallTotalMwhSales
        {
            get { return Common.Utility.Common.Round(smallTotalMwhSales); }
            set { smallTotalMwhSales = value; }
        }
        private decimal? smallTotalRevenue;
        public decimal? SmallTotalRevenue
        {
            get { return Common.Utility.Common.Round(smallTotalRevenue); }
            set { smallTotalRevenue = value; }
        }
        private decimal? largeTotalMwhSales;
        public decimal? LargeTotalMwhSales
        {
            get { return Common.Utility.Common.Round(largeTotalMwhSales); }
            set { largeTotalMwhSales = value; }
        }
        private decimal? largeTotalRevenue;
        public decimal? LargeTotalRevenue
        {
            get { return Common.Utility.Common.Round(largeTotalRevenue); }
            set { largeTotalRevenue = value; }
        }

        private decimal? rpsHydro;
        public decimal? RpsHydro
        {
            get { return Common.Utility.Common.Round(rpsHydro); }
            set { rpsHydro = value; }
        }
        private decimal? rpsBiomass;
        public decimal? RpsBiomass
        {
            get { return Common.Utility.Common.Round(rpsBiomass); }
            set { rpsBiomass = value; }
        }
        private decimal? rpsWind;
        public decimal? RpsWind
        {
            get { return Common.Utility.Common.Round(rpsWind); }
            set { rpsWind = value; }
        }
        private decimal? rpsSolar;
        public decimal? RpsSolar
        {
            get { return Common.Utility.Common.Round(rpsSolar); }
            set { rpsSolar = value; }
        }
        private decimal? rpsMunicipalSolidWaste;
        public decimal? RpsMunicipalSolidWaste
        {
            get { return Common.Utility.Common.Round(rpsMunicipalSolidWaste); }
            set { rpsMunicipalSolidWaste = value; }
        }
        private decimal? rpsOther;
        public decimal? RpsOther
        {
            get { return Common.Utility.Common.Round(rpsOther); }
            set { rpsOther = value; }
        }
        private decimal? averagePricePaid;
        public decimal? AveragePricePaid
        {
            get { return Common.Utility.Common.Round(averagePricePaid); }
            set { averagePricePaid = value; }
        }

        private decimal? fuelMixHydro;
        public decimal? FuelMixHydro
        {
            get { return Common.Utility.Common.Round(fuelMixHydro); }
            set { fuelMixHydro = value; }
        }
        private decimal? fuelMixBiomass;
        public decimal? FuelMixBiomass
        {
            get { return Common.Utility.Common.Round(fuelMixBiomass); }
            set { fuelMixBiomass = value; }
        }
        private decimal? fuelMixSolar;
        public decimal? FuelMixSolar
        {
            get { return Common.Utility.Common.Round(fuelMixSolar); }
            set { fuelMixSolar = value; }
        }
        private decimal? fuelMixMunicipalSolidWaste;
        public decimal? FuelMixMunicipalSolidWaste
        {
            get { return Common.Utility.Common.Round(fuelMixMunicipalSolidWaste); }
            set { fuelMixMunicipalSolidWaste = value; }
        }
        private decimal? fuelMixOther;
        public decimal? FuelMixOther
        {
            get { return Common.Utility.Common.Round(fuelMixOther); }
            set { fuelMixOther = value; }
        }
        private decimal? fuelMixWind;
        public decimal? FuelMixWind
        {
            get { return Common.Utility.Common.Round(fuelMixWind); }
            set { fuelMixWind = value; }
        }
        private decimal? fuelMixCoal;
        public decimal? FuelMixCoal
        {
            get { return Common.Utility.Common.Round(fuelMixCoal); }
            set { fuelMixCoal = value; }
        }
        private decimal? fuelMixNuclear;
        public decimal? FuelMixNuclear
        {
            get { return Common.Utility.Common.Round(fuelMixNuclear); }
            set { fuelMixNuclear = value; }
        }

        private decimal? fuelMixGas;
        public decimal? FuelMixGas
        {
            get { return Common.Utility.Common.Round(fuelMixGas); }
            set { fuelMixGas = value; }
        }
        private decimal? fuelMixOil;
        public decimal? FuelMixOil
        {
            get { return Common.Utility.Common.Round(fuelMixOil); }
            set { fuelMixOil = value; }
        }
        private decimal? mwhsSalesExcluded;
        public decimal? MwhsSalesExcluded
        {
            get { return Common.Utility.Common.Round(mwhsSalesExcluded); }
            set { mwhsSalesExcluded = value; }
        }
        private decimal? altCompliancePay1;
        public decimal? AltCompliancePay1
        {
            get { return Common.Utility.Common.Round(altCompliancePay1); }
            set { altCompliancePay1 = value; }
        }
        private decimal? altCompliancePay2;
        public decimal? AltCompliancePay2
        {
            get { return Common.Utility.Common.Round(altCompliancePay2); }
            set { altCompliancePay2 = value; }
        }
        private string trackingNumber;
        public string TrackingNumber
        {
            get { return trackingNumber; }
            set { trackingNumber = value; }
        }
        #endregion

        #region Telephone-ILEC-UTILITY-Submission
        private int reportTeleIlecUtilitySeq;
        public int ReportTeleIlecUtilitySeq
        {
            get { return reportTeleIlecUtilitySeq; }
            set { reportTeleIlecUtilitySeq = value; }
        }
        private decimal? totalOpertngRev;
        public decimal? TotalOpertngRev
        {
            get { return Common.Utility.Common.Round(totalOpertngRev); }
            set { totalOpertngRev = value; }
        }
        private decimal? totalOpertngExp;
        public decimal? TotalOpertngExp
        {
            get { return Common.Utility.Common.Round(totalOpertngExp); }
            set { totalOpertngExp = value; }
        }
        private decimal? netOpertngInc;
        public decimal? NetOpertngInc
        {
            get { return Common.Utility.Common.Round(netOpertngInc); }
            set { netOpertngInc = value; }
        }

        private decimal? totalNonOpertngExpInc;
        public decimal? TotalNonOpertngExpInc
        {
            get { return Common.Utility.Common.Round(totalNonOpertngExpInc); }
            set { totalNonOpertngExpInc = value; }
        }
        private decimal? totalNonOpertngInc;
        public decimal? TotalNonOpertngInc
        {
            get { return Common.Utility.Common.Round(totalNonOpertngInc); }
            set { totalNonOpertngInc = value; }
        }
        private decimal? basicLocalServcRev;
        public decimal? BasicLocalServcRev
        {
            get { return Common.Utility.Common.Round(basicLocalServcRev); }
            set { basicLocalServcRev = value; }
        }
        private decimal? swtchSpeclAccessRev;
        public decimal? SwtchSpeclAccessRev
        {
            get { return Common.Utility.Common.Round(swtchSpeclAccessRev); }
            set { swtchSpeclAccessRev = value; }
        }
        private decimal? privalteLine;
        public decimal? PrivalteLine
        {
            get { return Common.Utility.Common.Round(privalteLine); }
            set { privalteLine = value; }
        }
        private decimal? interExchangeRev;
        public decimal? InterExchangeRev
        {
            get { return Common.Utility.Common.Round(interExchangeRev); }
            set { interExchangeRev = value; }
        }
        private decimal? miscellaneousRev;
        public decimal? MiscellaneousRev
        {
            get { return Common.Utility.Common.Round(miscellaneousRev); }
            set { miscellaneousRev = value; }
        }
        private decimal? totalRevSubAss;
        public decimal? TotalRevSubAss
        {
            get { return Common.Utility.Common.Round(totalRevSubAss); }
            set { totalRevSubAss = value; }
        }
        #endregion

        #region For Telephone CLEC UTILITY Submission
        private decimal? reportTelClecUtilitySeq;
        public decimal? ReportTelClecUtilitySeq
        {
            get { return Common.Utility.Common.Round(reportTelClecUtilitySeq); }
            set { reportTelClecUtilitySeq = value; }
        }
        private decimal? mirorClec;
        public decimal? MirorClec
        {
            get { return Common.Utility.Common.Round(mirorClec); }
            set { mirorClec = value; }
        }
        private decimal? mirorIxc;
        public decimal? MirorIxc
        {
            get { return Common.Utility.Common.Round(mirorIxc); }
            set { mirorIxc = value; }
        }
        private decimal? mirorTotal;
        public decimal? MirorTotal
        {
            get { return Common.Utility.Common.Round(mirorTotal); }
            set { mirorTotal = value; }
        }
        private decimal? totalRevGenMr;
        public decimal? TotalRevGenMr
        {
            get { return Common.Utility.Common.Round(totalRevGenMr); }
            set { totalRevGenMr = value; }
        }
        private decimal? totalRevGenMw;
        public decimal? TotalRevGenMw
        {
            get { return Common.Utility.Common.Round(totalRevGenMw); }
            set { totalRevGenMw = value; }
        }
        private decimal? totalRevGenMt;
        public decimal? TotalRevGenMt
        {
            get { return Common.Utility.Common.Round(totalRevGenMt); }
            set { totalRevGenMt = value; }
        }
        #endregion

        #region For Gas Utility Submission
        private decimal? reportGasUtilitySeq;
        public decimal? ReportGasUtilitySeq
        {
            get { return Common.Utility.Common.Round(reportGasUtilitySeq); }
            set { reportGasUtilitySeq = value; }
        }
        private decimal? totalUtilityPlant;
        public decimal? TotalUtilityPlant
        {
            get { return Common.Utility.Common.Round(totalUtilityPlant); }
            set { totalUtilityPlant = value; }
        }
        private decimal? netUtilityPlant;
        public decimal? NetUtilityPlant
        {
            get { return Common.Utility.Common.Round(netUtilityPlant); }
            set { netUtilityPlant = value; }
        }
        private decimal? totalPropCapital;
        public decimal? TotalPropCapital
        {
            get { return Common.Utility.Common.Round(totalPropCapital); }
            set { totalPropCapital = value; }
        }
        private decimal? totalLongTermDebt;
        public decimal? TotalLongTermDebt
        {
            get { return Common.Utility.Common.Round(totalLongTermDebt); }
            set { totalLongTermDebt = value; }
        }

        private decimal? maintenanceExp;
        public decimal? MaintenanceExp
        {
            get { return Common.Utility.Common.Round(maintenanceExp); }
            set { maintenanceExp = value; }
        }
        private decimal? netUtilityOpertngInc;
        public decimal? NetUtilityOpertngInc
        {
            get { return Common.Utility.Common.Round(netUtilityOpertngInc); }
            set { netUtilityOpertngInc = value; }
        }
        private decimal? totalGasOpertngRevBase;
        public decimal? TotalGasOpertngRevBase
        {
            get { return Common.Utility.Common.Round(totalGasOpertngRevBase); }
            set { totalGasOpertngRevBase = value; }
        }
        private decimal? totalGasOpertngRevGas;
        public decimal? TotalGasOpertngRevGas
        {
            get { return Common.Utility.Common.Round(totalGasOpertngRevGas); }
            set { totalGasOpertngRevGas = value; }
        }
        #endregion

        #region Common Properties
        private string reportYear;
        public string ReportYear
        {
            get { return reportYear; }
            set { reportYear = value; }
        }

        private int companySeq;
        public int CompanySeq
        {
            get { return companySeq; }
            set { companySeq = value; }
        }

        private string industrySubTypeCode;
        public string IndustrySubTypeCode
        {
            get { return industrySubTypeCode; }
            set { industrySubTypeCode = value; }
        }
        private string reportTypeCode;
        public string ReportTypeCode
        {
            get { return reportTypeCode; }
            set { reportTypeCode = value; }
        }
        private string createdBy;
        public string CreatedBy
        {
            get { return createdBy; }
            set { createdBy = value; }
        }

        private DateTime createdDate;
        public DateTime CreatedDate
        {
            get { return createdDate; }
            set { createdDate = value; }
        }

        private string updatedBy;
        public string UpdatedBy
        {
            get { return updatedBy; }
            set { updatedBy = value; }
        }

        private DateTime updatedDate;
        public DateTime UpdatedDate
        {
            get { return updatedDate; }
            set { updatedDate = value; }
        }

        private List<AttachDocumentEntity> documentList = new List<AttachDocumentEntity>();
        public List<AttachDocumentEntity> DocumentList
        {
            get { return documentList; }
            set { documentList = value; }
        }


        private List<ClassSalesStruct> classSalesList;
        public List<ClassSalesStruct> ClassSalesList
        {
            get { return classSalesList; }
            set { classSalesList = value; }
        }
        private decimal totalAttachmentSize;
        public decimal TotalAttachmentSize
        {
            get { return totalAttachmentSize; }
            set { totalAttachmentSize = value; }
        }

        private System.String companyOrgName;
        public System.String CompanyOrgName
        {
            get { return companyOrgName; }
            set { companyOrgName = value; }
        }


        private decimal? annualRevenueSubToAssessment;
        public decimal? AnnualRevenueSubToAssessment
        {
            get { return Common.Utility.Common.Round(annualRevenueSubToAssessment); }
            set { annualRevenueSubToAssessment = value; }
        }

        #endregion

    }
}
