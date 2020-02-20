package org.kemetkoder.astevens;

import java.util.*;

public class StarfleetShip implements ISpaceVessel {
    private double speed;
    private int level;  // used to determine the level of diagnostic to perform
    private VesselStatus currentVesselStatus;

    public StarfleetShip(){
        this.setCurrentVesselStatus(VesselStatus.Active);
    }

    public double getSpeed() {
        return speed;
    }

    public void setSpeed(double speed) {
        this.speed = speed;
    }

    public int getLevel() {
        return level;
    }

    public void setLevel(int level) {
        this.level = level;
    }

    public VesselStatus getCurrentVesselStatus() {
        return currentVesselStatus;
    }

    public void setCurrentVesselStatus(VesselStatus currentVesselStatus) {
        this.currentVesselStatus = currentVesselStatus;
    }

    @Override
    public void navigate(double pitch, double yaw, double roll) {
        // TODO: Make more interactive so that the user has to input pitch, yaw, and roll
        System.out.println("Navigating to " + pitch + " mark " + yaw);
    }

    @Override
    public void goToWarp() {
        Scanner warpSpeed = new Scanner(System.in);
        //double speed = 0.0;

        System.out.println("Enter the warp speed: ");
        this.setSpeed(warpSpeed.nextDouble());
        warpSpeed.nextLine();

        if(this.getSpeed() > 8.5)
            System.out.println("Warp speed " + this.getSpeed() + " is NOT recommended!");
        // TODO: Allow the captain to override.
        else {
            System.out.println("Going to warp speed " + speed);
            for (double sp = 1.0; sp <= speed; sp += 0.5) {
                if (sp == speed)
                    System.out.println("Warp " + sp + " achieved!");
                else
                    System.out.println("Warp " + sp + "... ");
            }
        }
    }

    @Override
    public VesselDiagnostic performDiagnostic(int level) {
        VesselDiagnostic diagnostic = new VesselDiagnostic();

        return diagnostic;
    }

    @Override
    public VesselStatus showVesselStatus() {
        return this.getCurrentVesselStatus();
    }

    @Override
    public String toString() {
        String statusStr = "Current status of the ship is: " + this.getCurrentVesselStatus();

        return statusStr;
    }
}
