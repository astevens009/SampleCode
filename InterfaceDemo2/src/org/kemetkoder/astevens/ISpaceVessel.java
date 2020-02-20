package org.kemetkoder.astevens;

public interface ISpaceVessel {
    enum VesselStatus{
        NonCommissioned,    // a ship that is brand new
        DeCommissioned,
        Active,
        OutForRepair,
        Destroyed,
        Missing
    }

    void navigate(double pitch, double yaw, double roll);
    void goToWarp();
    VesselDiagnostic performDiagnostic(int level);
    VesselStatus showVesselStatus();
}
