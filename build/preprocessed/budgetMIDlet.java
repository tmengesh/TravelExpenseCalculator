/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */

import javax.microedition.midlet.*;
import javax.microedition.lcdui.*;

/**
 * @author k8mige00
 */
public class budgetMIDlet extends MIDlet implements CommandListener {

    private boolean midletPaused = false;

    //<editor-fold defaultstate="collapsed" desc=" Generated Fields ">//GEN-BEGIN:|fields|0|
    private Form Expense;
    private TextField foodTextField;
    private TextField clothingTextField;
    private TextField transportTextField;
    private TextField InternetTextField;
    private Command backCommand;
    private Command calculateCommand;
    //</editor-fold>//GEN-END:|fields|0|

    /**
     * The budgetMIDlet constructor.
     */
    public budgetMIDlet() {
    }

    //<editor-fold defaultstate="collapsed" desc=" Generated Methods ">//GEN-BEGIN:|methods|0|
    //</editor-fold>//GEN-END:|methods|0|

    //<editor-fold defaultstate="collapsed" desc=" Generated Method: initialize ">//GEN-BEGIN:|0-initialize|0|0-preInitialize
    /**
     * Initilizes the application.
     * It is called only once when the MIDlet is started. The method is called before the <code>startMIDlet</code> method.
     */
    private void initialize() {//GEN-END:|0-initialize|0|0-preInitialize
        // write pre-initialize user code here
//GEN-LINE:|0-initialize|1|0-postInitialize
        // write post-initialize user code here
    }//GEN-BEGIN:|0-initialize|2|
    //</editor-fold>//GEN-END:|0-initialize|2|

    //<editor-fold defaultstate="collapsed" desc=" Generated Method: startMIDlet ">//GEN-BEGIN:|3-startMIDlet|0|3-preAction
    /**
     * Performs an action assigned to the Mobile Device - MIDlet Started point.
     */
    public void startMIDlet() {//GEN-END:|3-startMIDlet|0|3-preAction
        // write pre-action user code here
        switchDisplayable(null, getExpense());//GEN-LINE:|3-startMIDlet|1|3-postAction
        // write post-action user code here
    }//GEN-BEGIN:|3-startMIDlet|2|
    //</editor-fold>//GEN-END:|3-startMIDlet|2|

    //<editor-fold defaultstate="collapsed" desc=" Generated Method: resumeMIDlet ">//GEN-BEGIN:|4-resumeMIDlet|0|4-preAction
    /**
     * Performs an action assigned to the Mobile Device - MIDlet Resumed point.
     */
    public void resumeMIDlet() {//GEN-END:|4-resumeMIDlet|0|4-preAction
        // write pre-action user code here
//GEN-LINE:|4-resumeMIDlet|1|4-postAction
        // write post-action user code here
    }//GEN-BEGIN:|4-resumeMIDlet|2|
    //</editor-fold>//GEN-END:|4-resumeMIDlet|2|

    //<editor-fold defaultstate="collapsed" desc=" Generated Method: switchDisplayable ">//GEN-BEGIN:|5-switchDisplayable|0|5-preSwitch
    /**
     * Switches a current displayable in a display. The <code>display</code> instance is taken from <code>getDisplay</code> method. This method is used by all actions in the design for switching displayable.
     * @param alert the Alert which is temporarily set to the display; if <code>null</code>, then <code>nextDisplayable</code> is set immediately
     * @param nextDisplayable the Displayable to be set
     */
    public void switchDisplayable(Alert alert, Displayable nextDisplayable) {//GEN-END:|5-switchDisplayable|0|5-preSwitch
        // write pre-switch user code here
        Display display = getDisplay();//GEN-BEGIN:|5-switchDisplayable|1|5-postSwitch
        if (alert == null) {
            display.setCurrent(nextDisplayable);
        } else {
            display.setCurrent(alert, nextDisplayable);
        }//GEN-END:|5-switchDisplayable|1|5-postSwitch
        // write post-switch user code here
    }//GEN-BEGIN:|5-switchDisplayable|2|
    //</editor-fold>//GEN-END:|5-switchDisplayable|2|

    //<editor-fold defaultstate="collapsed" desc=" Generated Method: commandAction for Displayables ">//GEN-BEGIN:|7-commandAction|0|7-preCommandAction
    /**
     * Called by a system to indicated that a command has been invoked on a particular displayable.
     * @param command the Command that was invoked
     * @param displayable the Displayable where the command was invoked
     */
    public void commandAction(Command command, Displayable displayable) {//GEN-END:|7-commandAction|0|7-preCommandAction
        // write pre-action user code here
        if (displayable == Expense) {//GEN-BEGIN:|7-commandAction|1|22-preAction
            if (command == backCommand) {//GEN-END:|7-commandAction|1|22-preAction
                // write pre-action user code here
                exitMIDlet();//GEN-LINE:|7-commandAction|2|22-postAction
                // write post-action user code here
            } else if (command == calculateCommand) {//GEN-LINE:|7-commandAction|3|25-preAction
                // write pre-action user code here
//GEN-LINE:|7-commandAction|4|25-postAction
                // write post-action user code here
            }//GEN-BEGIN:|7-commandAction|5|7-postCommandAction
        }//GEN-END:|7-commandAction|5|7-postCommandAction
        // write post-action user code here
    }//GEN-BEGIN:|7-commandAction|6|
    //</editor-fold>//GEN-END:|7-commandAction|6|

    //<editor-fold defaultstate="collapsed" desc=" Generated Getter: Expense ">//GEN-BEGIN:|15-getter|0|15-preInit
    /**
     * Returns an initiliazed instance of Expense component.
     * @return the initialized component instance
     */
    public Form getExpense() {
        if (Expense == null) {//GEN-END:|15-getter|0|15-preInit
            // write pre-init user code here
            Expense = new Form("Expenses", new Item[] { getFoodTextField(), getClothingTextField(), getTransportTextField(), getInternetTextField() });//GEN-BEGIN:|15-getter|1|15-postInit
            Expense.addCommand(getBackCommand());
            Expense.addCommand(getCalculateCommand());
            Expense.setCommandListener(this);//GEN-END:|15-getter|1|15-postInit
            // write post-init user code here
        }//GEN-BEGIN:|15-getter|2|
        return Expense;
    }
    //</editor-fold>//GEN-END:|15-getter|2|

    //<editor-fold defaultstate="collapsed" desc=" Generated Getter: foodTextField ">//GEN-BEGIN:|17-getter|0|17-preInit
    /**
     * Returns an initiliazed instance of foodTextField component.
     * @return the initialized component instance
     */
    public TextField getFoodTextField() {
        if (foodTextField == null) {//GEN-END:|17-getter|0|17-preInit
            // write pre-init user code here
            foodTextField = new TextField("Food:", null, 32, TextField.ANY);//GEN-LINE:|17-getter|1|17-postInit
            // write post-init user code here
        }//GEN-BEGIN:|17-getter|2|
        return foodTextField;
    }
    //</editor-fold>//GEN-END:|17-getter|2|

    //<editor-fold defaultstate="collapsed" desc=" Generated Getter: clothingTextField ">//GEN-BEGIN:|18-getter|0|18-preInit
    /**
     * Returns an initiliazed instance of clothingTextField component.
     * @return the initialized component instance
     */
    public TextField getClothingTextField() {
        if (clothingTextField == null) {//GEN-END:|18-getter|0|18-preInit
            // write pre-init user code here
            clothingTextField = new TextField("Clothing:", null, 32, TextField.ANY);//GEN-LINE:|18-getter|1|18-postInit
            // write post-init user code here
        }//GEN-BEGIN:|18-getter|2|
        return clothingTextField;
    }
    //</editor-fold>//GEN-END:|18-getter|2|

    //<editor-fold defaultstate="collapsed" desc=" Generated Getter: transportTextField ">//GEN-BEGIN:|19-getter|0|19-preInit
    /**
     * Returns an initiliazed instance of transportTextField component.
     * @return the initialized component instance
     */
    public TextField getTransportTextField() {
        if (transportTextField == null) {//GEN-END:|19-getter|0|19-preInit
            // write pre-init user code here
            transportTextField = new TextField("Transport", null, 32, TextField.ANY);//GEN-LINE:|19-getter|1|19-postInit
            // write post-init user code here
        }//GEN-BEGIN:|19-getter|2|
        return transportTextField;
    }
    //</editor-fold>//GEN-END:|19-getter|2|

    //<editor-fold defaultstate="collapsed" desc=" Generated Getter: InternetTextField ">//GEN-BEGIN:|20-getter|0|20-preInit
    /**
     * Returns an initiliazed instance of InternetTextField component.
     * @return the initialized component instance
     */
    public TextField getInternetTextField() {
        if (InternetTextField == null) {//GEN-END:|20-getter|0|20-preInit
            // write pre-init user code here
            InternetTextField = new TextField("Internet:", null, 32, TextField.ANY);//GEN-LINE:|20-getter|1|20-postInit
            // write post-init user code here
        }//GEN-BEGIN:|20-getter|2|
        return InternetTextField;
    }
    //</editor-fold>//GEN-END:|20-getter|2|

    //<editor-fold defaultstate="collapsed" desc=" Generated Getter: backCommand ">//GEN-BEGIN:|21-getter|0|21-preInit
    /**
     * Returns an initiliazed instance of backCommand component.
     * @return the initialized component instance
     */
    public Command getBackCommand() {
        if (backCommand == null) {//GEN-END:|21-getter|0|21-preInit
            // write pre-init user code here
            backCommand = new Command("Back", Command.BACK, 0);//GEN-LINE:|21-getter|1|21-postInit
            // write post-init user code here
        }//GEN-BEGIN:|21-getter|2|
        return backCommand;
    }
    //</editor-fold>//GEN-END:|21-getter|2|

    //<editor-fold defaultstate="collapsed" desc=" Generated Getter: calculateCommand ">//GEN-BEGIN:|24-getter|0|24-preInit
    /**
     * Returns an initiliazed instance of calculateCommand component.
     * @return the initialized component instance
     */
    public Command getCalculateCommand() {
        if (calculateCommand == null) {//GEN-END:|24-getter|0|24-preInit
            // write pre-init user code here
            calculateCommand = new Command("calculate", Command.ITEM, 0);//GEN-LINE:|24-getter|1|24-postInit
            // write post-init user code here
        }//GEN-BEGIN:|24-getter|2|
        return calculateCommand;
    }
    //</editor-fold>//GEN-END:|24-getter|2|

    /**
     * Returns a display instance.
     * @return the display instance.
     */
    public Display getDisplay () {
        return Display.getDisplay(this);
    }

    /**
     * Exits MIDlet.
     */
    public void exitMIDlet() {
        switchDisplayable (null, null);
        destroyApp(true);
        notifyDestroyed();
    }

    /**
     * Called when MIDlet is started.
     * Checks whether the MIDlet have been already started and initialize/starts or resumes the MIDlet.
     */
    public void startApp() {
        if (midletPaused) {
            resumeMIDlet ();
        } else {
            initialize ();
            startMIDlet ();
        }
        midletPaused = false;
    }

    /**
     * Called when MIDlet is paused.
     */
    public void pauseApp() {
        midletPaused = true;
    }

    /**
     * Called to signal the MIDlet to terminate.
     * @param unconditional if true, then the MIDlet has to be unconditionally terminated and all resources has to be released.
     */
    public void destroyApp(boolean unconditional) {
    }

}
