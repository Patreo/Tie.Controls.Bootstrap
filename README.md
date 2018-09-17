# Bootstrap.A11y

A collection of accessible [Twitter Bootstrap v3.3.7](https://github.com/twbs/bootstrap/tree/v3.3.7) user controls for ASP.NET. It's easy to forget to add ARIA attributes and other accessibility markup. With these controls, it's all handled for you! 

This project is forked from the [Tie.Controls.Bootstrap](https://github.com/Patreo/Tie.Controls.Bootstrap) project by [pmcfernandes](https://github.com/pmcfernandes) and features additional controls and accessibility markup. Care has been taken to maintain backwards compatibility, making the transition from Tie.Controls.Bootstrap to Bootstrap.A11y as smooth as possible.

[![Codacy Badge](https://api.codacy.com/project/badge/Grade/c1003b1dec254b0395506d59c5319aa9)](https://www.codacy.com/app/kinzdesign/Bootstrap.A11y?utm_source=github.com&amp;utm_medium=referral&amp;utm_content=wsomweb/Bootstrap.A11y&amp;utm_campaign=Badge_Grade)

## Getting Started

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes.

### Installing the Package

Just open your Visual Studio and in Tools > Nuget > Package Manager Console write follow line

    Install-Package Bootstrap.A11y
    
See more informations here: https://www.nuget.org/packages/Bootstrap.A11y/    

### Registering the Controls

Add the following entry to your root [web.config](Samples/Web.config) file. This registers the controls for use anywhere on your site with the `twt:` prefix:

    <system.web>
        <pages>
            <controls>
                <add tagPrefix="twt" namespace="Bootstrap.A11y" assembly="Bootstrap.A11y" />
            </controls>
        </pages>
    </system.web>

If you only want the Bootstrap controls to be available in part of your website, you can add the above entry to a non-root web.config file. 
If you want a different tag prefix than `twt:`, edit the entry accordingly.

### Configuration

By default, the CSS and JavaScript of the [PayPal Bootstrap Accessibility Plugin](https://github.com/paypal/bootstrap-accessibility-plugin) are added to the page (using embedded resources and ClientScriptManager) when any of the following controls are added to a page:
*   Alert
*   Dropdown
*   Carousel
*   Modal
*   TabControl

This behavior can be modified in the `appSettings` section of your root [web.config](Samples/Web.config) file:

If you are already including the Bootstrap Accessibility Plugin CSS and/or JS in your site, you can disable the ClientScriptManager injection by adding one or both of the following settings:

    <add key="Bootstrap.InjectA11yCss" value="False" />
    <add key="Bootstrap.InjectA11yJs" value="False" />

Alternatively, if you don't want either injected, you can use this setting instead:
    
    <add key="Bootstrap.AccessibilityPlugin" value="None" />

If you prefer to use [jongund's modified version of the PayPal Bootstrap Accessibility Plugin](https://github.com/jongund/bootstrap-accessibility-plugin/), you can add this setting:

    <add key="Bootstrap.AccessibilityPlugin" value="JonGund" />

**Note:** The value of `Bootstrap.AccessibilityPlugin` should be the same across the site. Changing the value in a child web.config file will lead to unexpected results as the value is loaded from configuration once and stored in a static property.

## Deployment

When deploying to a server, only the `Bootstrap.A11y.dll` file is needed.

## Documentation

[HTML documentation](https://wsomweb.github.io/Bootstrap.A11y/docs/) is available within the project's [`docs` folder](docs/). This documentation is generated using [Sandcastle Help File Generator](https://ewsoftware.github.io/SHFB/index.html).

### Some Examples of Usage

The [Samples project](Samples/) provides additional examples based on the [Bootstrap v3.3 documentation](https://getbootstrap.com/docs/3.3/). Simply open and run the project on your local machine.

#### [Page Header](Samples/css/type.aspx)

    <twt:PageHeader ID="PageHeader1" runat="server" Title="Heading" />

#### [Labels](Samples/components/labels.aspx)

    <twt:Label ID="Label1" runat="server" Text="Label Message" LabelType="Default" />
    <twt:Label ID="Label2" runat="server" Text="Label Message" LabelType="Primary" />
    <twt:Label ID="Label3" runat="server" Text="Label Message" LabelType="Success" />
    <twt:Label ID="Label4" runat="server" Text="Label Message" LabelType="Info" />
    <twt:Label ID="Label5" runat="server" Text="Label Message" LabelType="Warning" />
    <twt:Label ID="Label6" runat="server" Text="Label Message" LabelType="Danger" />
    
#### [Badges](Samples/components/badges.aspx)

    <twt:Badge ID="Badge1" runat="server" Text="42" />
    
#### [Button Groups](Samples/components/btn-groups.aspx)

    <twt:ButtonGroup ID="ButtonGroup1" runat="server">
        <Buttons>
            <twt:Button ID="Button2" runat="server" Text="Left" />
            <twt:Button ID="Button3" runat="server" Text="Center" />
            <twt:Button ID="Button4" runat="server" Text="Right" ButtonType="Inverse" />
        </Buttons>
    </twt:ButtonGroup>
    
#### [Toolbars](Samples/components/btn-groups.aspx)

    <twt:ButtonGroup ID="ButtonGroup6" runat="server" Toolbar="true">
        <Buttons>
             <twt:ButtonGroup ID="ButtonGroup7" runat="server">
                <Buttons>
                    <twt:Button ID="Button17" runat="server" Text="1" />
                    <twt:Button ID="Button18" runat="server" Text="2" />
                    <twt:Button ID="Button19" runat="server" Text="3" />
                    <twt:Button ID="Button20" runat="server" Text="4" />
                </Buttons>
            </twt:ButtonGroup>
             <twt:ButtonGroup ID="ButtonGroup8" runat="server">
                <Buttons>
                    <twt:Button ID="Button21" runat="server" Text="5" />
                    <twt:Button ID="Button22" runat="server" Text="6" />
                    <twt:Button ID="Button23" runat="server" Text="7" />
                </Buttons>
            </twt:ButtonGroup>
             <twt:ButtonGroup ID="ButtonGroup9" runat="server">
                <Buttons>
                    <twt:Button ID="Button24" runat="server" Text="8" />
                </Buttons>
            </twt:ButtonGroup>
        </Buttons>
    </twt:ButtonGroup>
    
#### [ProgressBars](Samples/components/progress.aspx)

    <twt:ProgressBar ID="ProgressBar3" runat="server" Value="40" ProgressBarStyle="Success" />
    <twt:ProgressBar ID="ProgressBar4" runat="server" Value="20" ProgressBarStyle="Info" />
    <twt:ProgressBar ID="ProgressBar5" runat="server" Value="60" ProgressBarStyle="Warning" />
    <twt:ProgressBar ID="ProgressBar6" runat="server" Value="80" ProgressBarStyle="Danger" />
    
#### [Alerts](Samples/components/alerts.aspx)

    <twt:Alert ID="Alert1" runat="server" Dismissible="false" AlertType="Success">
        <Content>
            <p>Well done! You successfully read this important alert message.</p>
        </Content>
    </twt:Alert>

## Authors

* **Pedro Fernandes** - *Initial work* - [pmcfernandes](https://github.com/pmcfernandes)
* **Kinsey Roberts** - *Accessibility overhaul* - [kinzdesign](https://github.com/kinzdesign) for [Weatherhead School of Management](https://github.com/wsomweb) at [Case Western Reserve University](https://github.com/cwru)

## License

The code in this project is licensed under the GNU General Public License - see the [LICENSE](LICENSE) file for details.

The documentation in the Samples project is adapted from the [Bootstrap team](https://github.com/twbs)'s [version 3.3.7 documentation](https://getbootstrap.com/docs/3.3/) under the [CC BY 3.0](https://creativecommons.org/licenses/by/3.0/) license and is released under the same [CC BY 3.0](https://creativecommons.org/licenses/by/3.0/) license.
