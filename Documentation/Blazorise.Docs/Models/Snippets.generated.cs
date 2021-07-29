//-----------------------------------------------------------------------
// This file is autogenerated by Blazorise.Docs.Compiler
// Any changes to this file will be overwritten on build
// <auto-generated />
//-----------------------------------------------------------------------

namespace Blazorise.Docs.Models
{
    public static partial class Snippets
    {
        public const string BasicAccordionExample = @"<Accordion>
    <Collapse Visible=""@collapse1Visible"">
        <CollapseHeader>
            <Heading Size=""HeadingSize.Is5"">
                <Button Clicked=""@(()=>collapse1Visible = !collapse1Visible)"">Switch 1</Button>
            </Heading>
        </CollapseHeader>
        <CollapseBody>
            Anim pariatur cliche reprehenderit, enim eiusmod high life accusamus terry richardson ad squid. 3 wolf moon officia aute, non cupidatat skateboard dolor brunch. Food truck quinoa nesciunt laborum eiusmod. Brunch 3 wolf moon tempor, sunt aliqua put a bird on it squid single-origin coffee nulla assumenda shoreditch et. Nihil anim keffiyeh helvetica, craft beer labore wes anderson cred nesciunt sapiente ea proident. Ad vegan excepteur butcher vice lomo. Leggings occaecat craft beer farm-to-table, raw denim aesthetic synth nesciunt you probably haven't heard of them accusamus labore sustainable VHS.
        </CollapseBody>
    </Collapse>
    <Collapse Visible=""@collapse2Visible"">
        <CollapseHeader>
            <Heading Size=""HeadingSize.Is5"">
                <Button Clicked=""@(()=>collapse2Visible = !collapse2Visible)"">Switch 2</Button>
            </Heading>
        </CollapseHeader>
        <CollapseBody>
            Anim pariatur cliche reprehenderit, enim eiusmod high life accusamus terry richardson ad squid. 3 wolf moon officia aute, non cupidatat skateboard dolor brunch. Food truck quinoa nesciunt laborum eiusmod. Brunch 3 wolf moon tempor, sunt aliqua put a bird on it squid single-origin coffee nulla assumenda shoreditch et. Nihil anim keffiyeh helvetica, craft beer labore wes anderson cred nesciunt sapiente ea proident. Ad vegan excepteur butcher vice lomo. Leggings occaecat craft beer farm-to-table, raw denim aesthetic synth nesciunt you probably haven't heard of them accusamus labore sustainable VHS.
        </CollapseBody>
    </Collapse>
    <Collapse Visible=""@collapse3Visible"">
        <CollapseHeader>
            <Heading Size=""HeadingSize.Is5"">
                <Button Clicked=""@(()=>collapse3Visible = !collapse3Visible)"">Switch 3</Button>
            </Heading>
        </CollapseHeader>
        <CollapseBody>
            Anim pariatur cliche reprehenderit, enim eiusmod high life accusamus terry richardson ad squid. 3 wolf moon officia aute, non cupidatat skateboard dolor brunch. Food truck quinoa nesciunt laborum eiusmod. Brunch 3 wolf moon tempor, sunt aliqua put a bird on it squid single-origin coffee nulla assumenda shoreditch et. Nihil anim keffiyeh helvetica, craft beer labore wes anderson cred nesciunt sapiente ea proident. Ad vegan excepteur butcher vice lomo. Leggings occaecat craft beer farm-to-table, raw denim aesthetic synth nesciunt you probably haven't heard of them accusamus labore sustainable VHS.
        </CollapseBody>
    </Collapse>
</Accordion>
@code{
    bool collapse1Visible = true;
    bool collapse2Visible = false;
    bool collapse3Visible = false;
}";

        public const string ButtonAddonExample = @"<Addons>
    <Addon AddonType=""AddonType.Body"">
        <TextEdit Placeholder=""Recipient's username"" />
    </Addon>
    <Addon AddonType=""AddonType.End"">
        <Button Color=""Color.Secondary"">Button</Button>
    </Addon>
</Addons>";

        public const string DropdownAddonExample = @"<Addons>
    <Addon AddonType=""AddonType.Start"">
        <Dropdown>
            <DropdownToggle Color=""Color.Primary"">Dropdown</DropdownToggle>
            <DropdownMenu>
                <DropdownItem>Action</DropdownItem>
                <DropdownItem>Another action</DropdownItem>
                <DropdownItem>Something else here</DropdownItem>
                <DropdownDivider />
                <DropdownItem>Separated link</DropdownItem>
            </DropdownMenu>
        </Dropdown>
    </Addon>
    <Addon AddonType=""AddonType.Body"">
        <TextEdit />
    </Addon>
</Addons>";

        public const string MultipleAddonsExample = @"<Addons>
    <Addon AddonType=""AddonType.Start"">
        <AddonLabel>Start</AddonLabel>
    </Addon>
    <Addon AddonType=""AddonType.Body"">
        <TextEdit Placeholder=""Placeholder"" />
    </Addon>
    <Addon AddonType=""AddonType.End"">
        <AddonLabel>End</AddonLabel>
    </Addon>
</Addons>";

        public const string StaticAddonExample = @"<Addons>
    <Addon AddonType=""AddonType.Start"">
        <AddonLabel>@@</AddonLabel>
    </Addon>
    <Addon AddonType=""AddonType.Body"">
        <TextEdit Placeholder=""Username"" />
    </Addon>
</Addons>";

        public const string AlertUseProgrammaticallyExample = @"<Alert @ref=""myAlert"" Color=""Color.Success"">
    <AlertMessage>
        Alert test.
    </AlertMessage>
</Alert>

<Button Clicked=""@OnButtonClick"" Color=""Color.Primary"">Show alert</Button>

@code{
    Alert myAlert;

    Task OnButtonClick()
    {
        myAlert.Show();

        return Task.CompletedTask;
    }
}";

        public const string AlertUseWithBindExample = @"<Alert Color=""Color.Success"" @bind-Visible=""@visible"">
    <AlertMessage>
        Alert test.
    </AlertMessage>
</Alert>

<Button Clicked=""@OnButtonClick"" Color=""Color.Primary"">Toggle alert</Button>

@code {
    bool visible = true;

    Task OnButtonClick()
    {
        visible = !visible;

        return Task.CompletedTask;
    }
}";

        public const string AlertWithContentExample = @"<Alert Color=""Color.Info"" @bind-Visible=""@visible"">
    <Heading Size=""HeadingSize.Is4"" TextColor=""TextColor.Success"">
        Big one!
        <CloseButton />
    </Heading>
    <Paragraph>
        Lorem ipsum dolor sit amet, consectetur adipisicing elit. Duis mollis, est non commodo luctus, nisi erat porttitor ligula, eget lacinia odio sem nec elit. Cras mattis consectetur purus sit amet fermentum.
    </Paragraph>
    <Paragraph>
        <Button Color=""Color.Info"">Wanna do this</Button>
        <Button Color=""Color.Light"">Or do this</Button>
    </Paragraph>
</Alert>
@code {
    bool visible = true;
}";

        public const string BasicAlertExample = @"<Alert Color=""Color.Success"" Visible>
    <AlertMessage>Well done!</AlertMessage>
    <AlertDescription>You successfully read this important alert message.</AlertDescription>
</Alert>";

        public const string CloseAlertExample = @"<Alert Color=""Color.Success"" @bind-Visible=""@visible"">
    <AlertDescription>
        Lorem ipsum dolor sit amet, consectetur adipisicing elit.
    </AlertDescription>
    <AlertMessage>
        Alert Link.
    </AlertMessage>
    <CloseButton />
</Alert>
@code {
    bool visible = true;
}";

        public const string ActiveButtonExample = @"<Button Color=""Color.Primary"" Active>Primary</Button>
<Button Color=""Color.Secondary"" Active>Secondary</Button>";

        public const string BlockButtonExample = @"<Button Color=""Color.Primary"" Block>Blocked primary</Button>
<Button Color=""Color.Secondary"" Block>Blocked secondary</Button>";

        public const string ButtonExample = @"<Button Color=""Color.Primary"">Click me</Button>";

        public const string ButtonGroupExample = @"<Buttons>
    <Button Color=""Color.Secondary"">LEFT</Button>
    <Button Color=""Color.Secondary"">CENTER</Button>
    <Button Color=""Color.Secondary"">RIGHT</Button>
</Buttons>";

        public const string ButtonUsageExample = @"<Button Color=""Color.Primary"" Clicked=""@OnButtonClicked"">Click me</Button>
@code{
    [Inject] INotificationService NotificationService { get; set; }

    Task OnButtonClicked()
    {
        return NotificationService.Info( ""Hello world!"" );
    }
}";

        public const string ColorButtonsExample = @"<Button Color=""Color.Primary"">Primary</Button>
<Button Color=""Color.Secondary"">Secondary</Button>
<Button Color=""Color.Success"">Success</Button>
<Button Color=""Color.Warning"">Warning</Button>
<Button Color=""Color.Danger"">Danger</Button>
<Button Color=""Color.Info"">Info</Button>
<Button Color=""Color.Light"">Light</Button>
<Button Color=""Color.Dark"">Dark</Button>
<Button>None</Button>";

        public const string DisabledButtonExample = @"<Button Color=""Color.Primary"" Disabled>Primary</Button>
<Button Color=""Color.Secondary"" Disabled>Secondary</Button>";

        public const string LinkButtonExample = @"<Button Color=""Color.Primary"" Type=""ButtonType.Link"" To=""#"">Primary link</Button>
<Button Color=""Color.Secondary"" Type=""ButtonType.Link"" To=""#"" Target=""Target.Blank"">Secondary link</Button>";

        public const string LoadingButtonExample = @"<Button Color=""Color.Primary"" Loading>Primary</Button>
<Button Color=""Color.Primary"" Clicked=""@ShowLoading"" Loading=""@isLoading"">
    <LoadingTemplate>
        This is a custom loading template
    </LoadingTemplate>
    <ChildContent>
        Click to load
    </ChildContent>
</Button>
@code{
    private bool isLoading;

    private async Task ShowLoading()
    {
        isLoading = true;

        await Task.Delay( TimeSpan.FromSeconds( 3 ) );

        isLoading = false;
    }
}";

        public const string OutlineButtonExample = @"<Button Color=""Color.Primary"" Outline>Primary</Button>
<Button Color=""Color.Secondary"" Outline>Secondary</Button>
<Button Color=""Color.Success"" Outline>Success</Button>
<Button Color=""Color.Warning"" Outline>Warning</Button>
<Button Color=""Color.Danger"" Outline>Danger</Button>
<Button Color=""Color.Info"" Outline>Info</Button>
<Button Color=""Color.Light"" Outline>Light</Button>
<Button Color=""Color.Dark"" Outline>Dark</Button>
<Button Outline>None</Button>";

        public const string SubmitButtonExample = @"<Form>
    <Field Horizontal>
        <FieldLabel ColumnSize=""ColumnSize.Is2"">Name</FieldLabel>
        <FieldBody ColumnSize=""ColumnSize.Is10"">
            <TextEdit Placeholder=""Some text value..."" />
        </FieldBody>
    </Field>
    <Field>
        <Button Color=""Color.Primary"" Type=""ButtonType.Submit"" PreventDefaultOnSubmit=""true"">Submit</Button>
    </Field>
</Form>";

        public const string ToolbarButtonsExample = @"<Buttons Role=""ButtonsRole.Toolbar"">
    <Buttons Margin=""Margin.Is2.FromRight"">
        <Button Color=""Color.Primary"">Primary</Button>
        <Button Color=""Color.Secondary"">Secondary</Button>
        <Button Color=""Color.Info"">Info</Button>
    </Buttons>
    <Buttons>
        <Button Color=""Color.Danger"">Danger</Button>
        <Button Color=""Color.Warning"">Warning</Button>
    </Buttons>
    <Buttons Margin=""Margin.Is2.OnX"">
        <Button Color=""Color.Success"">Success</Button>
    </Buttons>
</Buttons>";

        public const string CardDeckExample = @"<CardDeck>
    <Card>
        <CardImage Source=""/img/gallery/2.jpg"" Alt=""Card image cap 3""></CardImage>
        <CardBody>
            <CardTitle Size=""5"">Card title 1</CardTitle>
            <CardText>
                This is a longer card with supporting text below as a natural lead-in to additional content. This content is a little bit longer.
            </CardText>
            <Button Color=""Color.Primary"">Button</Button>
        </CardBody>
    </Card>
    <Card>
        <CardImage Source=""/img/gallery/3.jpg"" Alt=""Card image cap 9""></CardImage>
        <CardBody>
            <CardTitle Size=""5"">Card title 2</CardTitle>
            <CardText>
                This card has supporting text below as a natural lead-in to additional content.
            </CardText>
            <Button Color=""Color.Primary"">Button</Button>
        </CardBody>
    </Card>
    <Card>
        <CardImage Source=""/img/gallery/4.jpg"" Alt=""Card image cap 12""></CardImage>
        <CardBody>
            <CardTitle Size=""5"">Card title 3</CardTitle>
            <CardText>
                This is a wider card with supporting text below as a natural lead-in to additional content. This card has even longer content than the first to show that equal height action.
            </CardText>
            <Button Color=""Color.Primary"">Button</Button>
        </CardBody>
    </Card>
</CardDeck>";

        public const string CardExample = @"<Card Margin=""Margin.Is4.OnY"">
    <CardImage Source=""img/gallery/7.jpg"" Alt=""Placeholder image"">
    </CardImage>
    <CardBody>
        <CardTitle Size=""5"">Card title</CardTitle>
        <CardText>
            Some quick example text to build on the card title and make up the bulk of the card's content.
        </CardText>
        <Button Color=""Color.Primary"">Button</Button>
    </CardBody>
</Card>";

        public const string CheckExample = @"<Check TValue=""bool"">Check me out</Check>";

        public const string CheckWithBindExample = @"<Check TValue=""bool"" @bind-Checked=""@rememberMe"">Remember Me</Check>

@code{
    bool rememberMe;
}";

        public const string CheckWithEventExample = @"<Check TValue=""bool"" Checked=""@rememberMe"" CheckedChanged=""@OnRememberMeChanged"">Remember Me</Check>

@code{
    bool rememberMe;

    void OnRememberMeChanged( bool value )
    {
        rememberMe = value;
    }
}";

        public const string BasicColorExample = @"<ColorEdit Color=""#ff0000"" />";

        public const string BasicDateEditExample = @"<DateEdit TValue=""DateTime?"" />";

        public const string BasicDatePickerExample = @"<DatePicker TValue=""DateTime?"" />";

        public const string DateEditDateTimeExample = @"<DateEdit TValue=""DateTime?"" InputMode=""DateInputMode.DateTime"" />";

        public const string DateEditWithBindExample = @"<DateEdit TValue=""DateTime?"" @bind-Date=""@selectedDate"" />

@code{
    DateTime? selectedDate;
}";

        public const string DateEditWithEventExample = @"<DateEdit TValue=""DateTime?"" Date=""@selectedDate"" DateChanged=""@OnDateChanged"" />

@code{
    DateTime? selectedDate;

    void OnDateChanged( DateTime? date )
    {
        selectedDate = date;
    }
}";

        public const string DatePickerWithIconExample = @"<Addons>
    <Addon AddonType=""AddonType.Body"">
        <DatePicker @ref=""@datePicker"" TValue=""DateTime?"" />
    </Addon>
    <Addon AddonType=""AddonType.End"">
        <Button Color=""Color.Light"" Clicked=""@(()=>datePicker.ToggleAsync())"">
            <Icon Name=""IconName.CalendarDay"" />
        </Button>
    </Addon>
</Addons>
@code{
    DatePicker<DateTime?> datePicker;
}";

        public const string DashedDividerExample = @"<Divider DividerType=""DividerType.Dashed"" />";

        public const string DottedDividerExample = @"<Divider DividerType=""DividerType.Dotted"" />";

        public const string SolidDividerExample = @"<Divider />";

        public const string TextContentDividerExample = @"<Divider DividerType=""DividerType.TextContent"" Text=""Hello Blazorise"" />";

        public const string BasicFieldExample = @"<Field>
    <TextEdit Placeholder=""Name"" />
</Field>";

        public const string BasicFieldsExample = @"<Fields>
    <Field ColumnSize=""ColumnSize.Is6.OnDesktop"">
        <FieldLabel>City</FieldLabel>
        <TextEdit />
    </Field>
    <Field ColumnSize=""ColumnSize.Is4.OnDesktop"">
        <FieldLabel>State</FieldLabel>
        <Select TValue=""string"">
        </Select>
    </Field>
    <Field ColumnSize=""ColumnSize.Is2.OnDesktop"">
        <FieldLabel>Zip</FieldLabel>
        <TextEdit />
    </Field>
</Fields>";

        public const string FieldHiddenExample = @"<Field Visibility=""Visibility.Invisible"">
    <TextEdit />
</Field>";

        public const string FieldWithHelpExample = @"<Field>
    <FieldLabel>Email address</FieldLabel>
    <TextEdit Placeholder=""Enter email"">
        <FieldHelp>Please enter a valid email address</FieldHelp>
    </TextEdit>
</Field>";

        public const string FieldWithLabelExample = @"<Field>
    <FieldLabel>Email address</FieldLabel>
    <TextEdit Placeholder=""Enter email"" />
</Field>";

        public const string HorizontalFieldExample = @"<Field Horizontal=""true"">
    <FieldLabel ColumnSize=""ColumnSize.Is2"">Name</FieldLabel>
    <FieldBody ColumnSize=""ColumnSize.Is10"">
        <TextEdit Placeholder=""Some text value..."" />
    </FieldBody>
</Field>";

        public const string ExtensionsLimitFileEditExample = @"<!-- Accept all image formats by IANA media type wildcard-->
<FileEdit Filter=""image/*"" />

<!-- Accept specific image formats by IANA type -->
<FileEdit Filter=""image/jpeg, image/png, image/gif"" />

<!-- Accept specific image formats by extension -->
<FileEdit Filter="".jpg, .png, .gif"" />";

        public const string MultipleFileEditExample = @"<FileEdit Changed=""@OnChanged"" Multiple=""true"" />
@code{
    Task OnChanged( FileChangedEventArgs e )
    {
        return Task.CompletedTask;
    }
}";

        public const string OpenReadStreamFileEditExample = @"@using System.IO

<FileEdit Changed=""@OnChanged"" Written=""@OnWritten"" Progressed=""@OnProgressed"" />

@code{
    string fileContent;

    const int OneMb = 1024 * 1024;

    async Task OnChanged( FileChangedEventArgs e )
    {
        try
        {
            var file = e.Files.FirstOrDefault();
            if ( file == null )
            {
                return;
            }

            var buffer = new byte[OneMb];
            using ( var bufferedStream = new BufferedStream( file.OpenReadStream( long.MaxValue ), OneMb ) )
            {
                int readCount = 0;
                int readBytes;
                while ( ( readBytes = await bufferedStream.ReadAsync( buffer, 0, OneMb ) ) > 0 )
                {
                    Console.WriteLine( $""Read:{readCount++} {readBytes / (double)OneMb} MB"" );
                    // Do work on the first 1MB of data
                }
            }
        }
        catch ( Exception exc )
        {
            Console.WriteLine( exc.Message );
        }
        finally
        {
            this.StateHasChanged();
        }
    }

    void OnWritten( FileWrittenEventArgs e )
    {
        Console.WriteLine( $""File: {e.File.Name} Position: {e.Position} Data: {Convert.ToBase64String( e.Data )}"" );
    }

    void OnProgressed( FileProgressedEventArgs e )
    {
        Console.WriteLine( $""File: {e.File.Name} Progress: {e.Percentage}"" );
    }
}";

        public const string ResetFileEditExample = @"<FileEdit @ref=""@fileEdit"" AutoReset=""false"" Changed=""@OnChanged"" />
@code{
    FileEdit fileEdit;

    Task OnChanged( FileChangedEventArgs e )
    {
        return Task.CompletedTask;
    }

    Task OnSomeButtonClick()
    {
        return fileEdit.Reset().AsTask();
    }
}";

        public const string SingleFileEditExample = @"<FileEdit Changed=""@OnChanged"" />
@code{
    Task OnChanged( FileChangedEventArgs e )
    {
        return Task.CompletedTask;
    }
}";

        public const string WriteToStreamFileEditExample = @"@using System.IO

<FileEdit Changed=""@OnChanged"" Written=""@OnWritten"" Progressed=""@OnProgressed"" />

@code{
    string fileContent;

    async Task OnChanged( FileChangedEventArgs e )
    {
        try
        {
            foreach ( var file in e.Files )
            {
                // A stream is going to be the destination stream we're writing to.
                using ( var stream = new MemoryStream() )
                {
                    // Here we're telling the FileEdit where to write the upload result
                    await file.WriteToStreamAsync( stream );

                    // Once we reach this line it means the file is fully uploaded.
                    // In this case we're going to offset to the beginning of file
                    // so we can read it.
                    stream.Seek( 0, SeekOrigin.Begin );

                    // Use the stream reader to read the content of uploaded file,
                    // in this case we can assume it is a textual file.
                    using ( var reader = new StreamReader( stream ) )
                    {
                        fileContent = await reader.ReadToEndAsync();
                    }
                }
            }
        }
        catch ( Exception exc )
        {
            Console.WriteLine( exc.Message );
        }
        finally
        {
            this.StateHasChanged();
        }
    }

    void OnWritten( FileWrittenEventArgs e )
    {
        Console.WriteLine( $""File: {e.File.Name} Position: {e.Position} Data: {Convert.ToBase64String( e.Data )}"" );
    }

    void OnProgressed( FileProgressedEventArgs e )
    {
        Console.WriteLine( $""File: {e.File.Name} Progress: {e.Percentage}"" );
    }
}";

        public const string AnchorLinkExample = @"<Link To=""#"">
    Link
</Link>";

        public const string BasicLinkExample = @"<Link To=""docs"">
    Link
</Link>";

        public const string BasicMemoEditExample = @"<MemoEdit Rows=""5"" />";

        public const string MemoEditTextChangedModeExample = @"public void ConfigureServices( IServiceCollection services )
{
  services
    .AddBlazorise( options =>
    {
      options.ChangeTextOnKeyPress = false;
    } );
}";

        public const string MemoEditTextDelayModeExample = @"public void ConfigureServices( IServiceCollection services )
{
  services
    .AddBlazorise( options =>
    {
      options.DelayTextOnKeyPress = true;
      options.DelayTextOnKeyPressInterval = 300;
    } );
}";

        public const string MemoEditWithBindExample = @"<MemoEdit @bind-Text=""@description"" />

@code{
    string description;
}";

        public const string MemoEditWithEventExample = @"<MemoEdit Text=""@description"" TextChanged=""@OnDescriptionChanged"" />

@code{
    string description;

    Task OnDescriptionChanged( string value )
    {
        description = value;

        return Task.CompletedTask;
    }
}";

        public const string BasicNumericEditExample = @"<NumericEdit Value=""123"" />";

        public const string NumericEditGenericExample = @"<NumericEdit TValue=""decimal?"" />";

        public const string BasicPageProgressExample = @"<PageProgress Visible=""true"" Value=""25"" />";

        public const string BasicProgressExample = @"<Progress Value=""25"" />";

        public const string IndeterminatePageProgressExample = @"<PageProgress Visible=""true"" />";

        public const string MultipleProgressExample = @"<Progress>
    <ProgressBar Value=""15"" />
    <ProgressBar Color=""Color.Success"" Value=""30"" />
    <ProgressBar Color=""Color.Info"" Value=""20"" />
</Progress>";

        public const string BasicRadioGroupExample = @"<RadioGroup TValue=""string"" Name=""colors"">
    <Radio TValue=""string"" Value=""@(""red"")"">Red</Radio>
    <Radio TValue=""string"" Value=""@(""green"")"">Green</Radio>
    <Radio TValue=""string"" Value=""@(""blue"")"">Blue</Radio>
</RadioGroup>";

        public const string RadioGroupButtonsExample = @"<RadioGroup TValue=""string"" Name=""colors"" Buttons=""true"">
    <Radio TValue=""string"" Value=""@(""red"")"">Red</Radio>
    <Radio TValue=""string"" Value=""@(""green"")"">Green</Radio>
    <Radio TValue=""string"" Value=""@(""blue"")"">Blue</Radio>
</RadioGroup>";

        public const string RadioGroupWithBindExample = @"<RadioGroup TValue=""string"" Name=""colors"" @bind-CheckedValue=""@checkedValue"">
    <Radio TValue=""string"" Value=""@(""red"")"">Red</Radio>
    <Radio TValue=""string"" Value=""@(""green"")"">Green</Radio>
    <Radio TValue=""string"" Value=""@(""blue"")"">Blue</Radio>
</RadioGroup>

@code{
    string checkedValue = ""green"";
}";

        public const string RadioGroupWithEventExample = @"<RadioGroup TValue=""string""
            Name=""colors""
            CheckedValue=""@checkedValue""
            CheckedValueChanged=""@OnCheckedValueChanged"">
    <Radio TValue=""string"" Value=""@(""red"")"">Red</Radio>
    <Radio TValue=""string"" Value=""@(""green"")"">Green</Radio>
    <Radio TValue=""string"" Value=""@(""blue"")"">Blue</Radio>
</RadioGroup>

@code{
    string checkedValue = ""green"";

    Task OnCheckedValueChanged( string value )
    {
        checkedValue = value;

        return Task.CompletedTask;
    }
}";

        public const string StandaloneRadioExample = @"<Radio TValue=""string"" Group=""colors"" Value=""@(""red"")"">Red</Radio>
<Radio TValue=""string"" Group=""colors"" Value=""@(""green"")"">Green</Radio>
<Radio TValue=""string"" Group=""colors"" Value=""@(""blue"")"">Blue</Radio>";

        public const string BasicSelectExample = @"<Select TValue=""int"">
    <SelectItem Value=""1"">One</SelectItem>
    <SelectItem Value=""2"">Two</SelectItem>
    <SelectItem Value=""3"">Three</SelectItem>
    <SelectItem Value=""4"">Four</SelectItem>
</Select>";

        public const string GroupSelectExample = @"<Select TValue=""int"">
    <SelectGroup Label=""Group 1"">
        <SelectItem Value=""1"">One</SelectItem>
        <SelectItem Value=""2"">Two</SelectItem>
    </SelectGroup>
    <SelectGroup Label=""Group 2"">
        <SelectItem Value=""3"">Three</SelectItem>
        <SelectItem Value=""4"">Four</SelectItem>
    </SelectGroup>
</Select>";

        public const string MultipleSelectExample = @"<Select TValue=""int"" Multiple=""true"">
    <SelectItem Value=""1"">One</SelectItem>
    <SelectItem Value=""2"">Two</SelectItem>
    <SelectItem Value=""3"">Three</SelectItem>
    <SelectItem Value=""4"">Four</SelectItem>
</Select>";

        public const string SelectWithBindExample = @"<Select @bind-SelectedValue=""@selectedValue"">
    <SelectItem Value=""1"">One</SelectItem>
    <SelectItem Value=""2"">Two</SelectItem>
    <SelectItem Value=""3"">Three</SelectItem>
    <SelectItem Value=""4"">Four</SelectItem>
</Select>

@code{
    int selectedValue;
}";

        public const string SelectWithEventExample = @"<Select TValue=""int"" SelectedValue=""@selectedValue"" SelectedValueChanged=""@OnSelectedValueChanged"">
    <SelectItem Value=""1"">One</SelectItem>
    <SelectItem Value=""2"">Two</SelectItem>
    <SelectItem Value=""3"">Three</SelectItem>
    <SelectItem Value=""4"">Four</SelectItem>
</Select>

@code{
    int selectedValue;

    Task OnSelectedValueChanged( int value )
    {
        selectedValue = value;
        Console.WriteLine( selectedValue );

        return Task.CompletedTask;
    }
}";

        public const string BasicSliderExample = @"<Slider TValue=""decimal"" Value=""25m"" Max=""100m"" />";

        public const string BasicSwitchExample = @"<Switch TValue=""bool"">Remember me</Switch>";

        public const string SwitchWithBindExample = @"<Switch TValue=""bool"" @bind-Checked=""@rememberMe"">Remember Me</Switch>

@code{
    bool rememberMe;
}";

        public const string SwitchWithEventExample = @"<Switch TValue=""bool"" Checked=""@rememberMe"" CheckedChanged=""@OnRememberMeChanged"">Remember Me</Switch>

@code{
    bool rememberMe;

    Task OnRememberMeChanged( bool value )
    {
        rememberMe = value;

        return Task.CompletedTask;
    }
}";

        public const string BasicTextEditExample = @"<TextEdit />";

        public const string TextEditDisabledExample = @"<TextEdit Disabled />";

        public const string TextEditMaskExample = @"<TextEdit MaskType=""MaskType.RegEx"" EditMask=""^[a-zA-Z ]*$"" />";

        public const string TextEditPatternExample = @"<Validation UsePattern=""true"">
    <TextEdit Pattern=""[A-Za-z]{3}"">
        <Feedback>
            <ValidationError>Pattern does not match!</ValidationError>
        </Feedback>
    </TextEdit>
</Validation>";

        public const string TextEditPlaceholderExample = @"<TextEdit Placeholder=""Some text value..."" />";

        public const string TextEditPlaintextExample = @"<TextEdit Plaintext />";

        public const string TextEditReadonlyExample = @"<TextEdit ReadOnly />";

        public const string TextEditRoleExample = @"<TextEdit Role=""TextRole.Email"" />
<TextEdit Role=""TextRole.Password"" />";

        public const string TextEditSizingExample = @"<TextEdit Size=""Size.Small"" />
<TextEdit Size=""Size.Large"" />";

        public const string TextEditTextChangedModeExample = @"public void ConfigureServices( IServiceCollection services )
{
  services
    .AddBlazorise( options =>
    {
      options.ChangeTextOnKeyPress = false;
    } );
}";

        public const string TextEditTextDelayModeExample = @"public void ConfigureServices( IServiceCollection services )
{
  services
    .AddBlazorise( options =>
    {
      options.DelayTextOnKeyPress = true;
      options.DelayTextOnKeyPressInterval = 300;
    } );
}";

        public const string TextEditWithBindExample = @"<TextEdit @bind-Text=""@name"" />

@code{
    string name;
}";

        public const string TextEditWithEventExample = @"<TextEdit Text=""@name"" TextChanged=""@OnNameChanged"" />

@code{
    string name;

    Task OnNameChanged( string value )
    {
        name = value;

        return Task.CompletedTask;
    }
}";

        public const string BasicTimeEditExample = @"<TimeEdit TValue=""TimeSpan?"" />";

        public const string BasicTimePickerExample = @"<TimePicker TValue=""TimeSpan?"" />";

        public const string TimeEditWithBindExample = @"<TimeEdit TValue=""TimeSpan?"" @bind-Time=""@selectedTime"" />

@code{
    TimeSpan? selectedTime;
}";

        public const string TimeEditWithEventExample = @"<TimeEdit TValue=""TimeSpan?"" Time=""@selectedTime"" TimeChanged=""@OnTimeChanged"" />

@code{
    TimeSpan? selectedTime;

    Task OnTimeChanged( TimeSpan? Time )
    {
        selectedTime = Time;

        return Task.CompletedTask;
    }
}";

        public const string TimePickerWithIconExample = @"<Addons>
    <Addon AddonType=""AddonType.Body"">
        <TimePicker @ref=""@timePicker"" TValue=""TimeSpan?"" />
    </Addon>
    <Addon AddonType=""AddonType.End"">
        <Button Color=""Color.Light"" Clicked=""@(()=>timePicker.ToggleAsync())"">
            <Icon Name=""IconName.CalendarDay"" />
        </Button>
    </Addon>
</Addons>
@code{
    TimePicker<TimeSpan?> timePicker;
}";

        public const string AsyncValidationExample = @"@using System.Threading

<Validation AsyncValidator=""@ValidateNameAsync"">
    <TextEdit Placeholder=""Enter name"">
        <Feedback>
            <ValidationError>Enter valid name!</ValidationError>
        </Feedback>
    </TextEdit>
</Validation>
@code{
    Random random = new Random();

    async Task ValidateNameAsync( ValidatorEventArgs e, CancellationToken cancellationToken )
    {
        cancellationToken.ThrowIfCancellationRequested();

        // some long running task or call to the rest API
        await Task.Delay( random.Next( 600 ) );

        e.Status = string.IsNullOrEmpty( Convert.ToString( e.Value ) )
            ? ValidationStatus.Error
            : ValidationStatus.Success;
    }
}";

        public const string AutoValidationExample = @"<Validations Mode=""ValidationMode.Auto"" ValidateOnLoad=""true"">
    ...
</Validations>";

        public const string BasicValidationExample = @"<Validation Validator=""@ValidateEmail"">
    <TextEdit Placeholder=""Enter email"">
        <Feedback>
            <ValidationNone>Please enter the email.</ValidationNone>
            <ValidationSuccess>Email is good.</ValidationSuccess>
            <ValidationError>Enter valid email!</ValidationError>
        </Feedback>
    </TextEdit>
</Validation>
@code{
    void ValidateEmail( ValidatorEventArgs e )
    {
        var email = Convert.ToString( e.Value );

        e.Status = string.IsNullOrEmpty( email ) ? ValidationStatus.None :
            email.Contains( ""@"" ) ? ValidationStatus.Success : ValidationStatus.Error;
    }
}";

        public const string DataAnnotationValidationExample = @"@using System.ComponentModel.DataAnnotations

<Validations Mode=""ValidationMode.Auto"" Model=""@user"">
    <Validation>
        <Field Horizontal=""true"">
            <FieldLabel ColumnSize=""ColumnSize.Is2"">Full Name</FieldLabel>
            <FieldBody ColumnSize=""ColumnSize.Is10"">
                <TextEdit Placeholder=""First and last name"" @bind-Text=""@user.Name"">
                    <Feedback>
                        <ValidationError />
                    </Feedback>
                </TextEdit>
            </FieldBody>
        </Field>
    </Validation>
    <Validation>
        <Field Horizontal=""true"">
            <FieldLabel ColumnSize=""ColumnSize.Is2"">Email</FieldLabel>
            <FieldBody ColumnSize=""ColumnSize.Is10"">
                <TextEdit Placeholder=""Enter email"" @bind-Text=""@user.Email"">
                    <Feedback>
                        <ValidationError />
                    </Feedback>
                </TextEdit>
            </FieldBody>
        </Field>
    </Validation>
    <Validation>
        <Field Horizontal=""true"">
            <FieldLabel ColumnSize=""ColumnSize.Is2"">Password</FieldLabel>
            <FieldBody ColumnSize=""ColumnSize.Is10"">
                <TextEdit Role=""TextRole.Password"" Placeholder=""Password"" @bind-Text=""@user.Password"">
                    <Feedback>
                        <ValidationError />
                    </Feedback>
                </TextEdit>
            </FieldBody>
        </Field>
    </Validation>
    <Validation>
        <Field Horizontal=""true"">
            <FieldLabel ColumnSize=""ColumnSize.Is2"">Re Password</FieldLabel>
            <FieldBody ColumnSize=""ColumnSize.Is10"">
                <TextEdit Role=""TextRole.Password"" Placeholder=""Retype password"" @bind-Text=""@user.ConfirmPassword"">
                    <Feedback>
                        <ValidationError />
                    </Feedback>
                </TextEdit>
            </FieldBody>
        </Field>
    </Validation>
</Validations>
@code{
    User user = new User();

    public class User
    {
        [Required]
        [StringLength( 10, ErrorMessage = ""Name is too long."" )]
        public string Name { get; set; }

        [Required]
        [EmailAddress( ErrorMessage = ""Invalid email."" )]
        public string Email { get; set; }

        [Required( ErrorMessage = ""Password is required"" )]
        [StringLength( 8, ErrorMessage = ""Must be between 5 and 8 characters"", MinimumLength = 5 )]
        [DataType( DataType.Password )]
        public string Password { get; set; }

        [Required( ErrorMessage = ""Confirm Password is required"" )]
        [StringLength( 8, ErrorMessage = ""Must be between 5 and 8 characters"", MinimumLength = 5 )]
        [DataType( DataType.Password )]
        [Compare( ""Password"" )]
        public string ConfirmPassword { get; set; }

        [Required]
        public string Title { get; set; }

        [Range( typeof( bool ), ""true"", ""true"", ErrorMessage = ""You gotta tick the box!"" )]
        public bool TermsAndConditions { get; set; }
    }
}";

        public const string LocalizationValidationExample = @"@using Blazorise.Localization

<Validation MessageLocalizer=""@Localize"">
</Validation>
@code{
    [Inject] ITextLocalizer<LocalizationValidationExample> L { get; set; }

    string Localize( string message, IEnumerable<string> arguments )
    {
        // You should probably do null checks here!
        return string.Format( L[message], arguments.ToArray() );
    }
}";

        public const string ManualValidationExample = @"<Validations @ref=""validations"" Mode=""ValidationMode.Manual"">
    <Validation Validator=""@ValidationRule.IsNotEmpty"">
        <Field>
            <TextEdit Placeholder=""Enter first name"" />
        </Field>
    </Validation>
    <Validation Validator=""@ValidationRule.IsNotEmpty"">
        <Field>
            <TextEdit Placeholder=""Enter last name"" />
        </Field>
    </Validation>
    <Button Color=""Color.Primary"" Clicked=""@Submit"">Submit</Button>
</Validations>
@code{
    Validations validations;

    void Submit()
    {
        if ( validations.ValidateAll() )
        {
            // do something
        }
    }
}";

        public const string PatternValidationExample = @"<Validation UsePattern=""true"">
    <TextEdit Pattern=""[A-Za-z]{3}"">
        <Feedback>
            <ValidationError>Pattern does not match!</ValidationError>
        </Feedback>
    </TextEdit>
</Validation>";

        public const string ValidationFeedbackExample = @"<Validation Validator=""@ValidateCheck"">
    <Check TValue=""bool"">
        <ChildContent>
            Check me out
        </ChildContent>
        <Feedback>
            <ValidationError>You must check me out!</ValidationError>
        </Feedback>
    </Check>
</Validation>
@code{
    void ValidateCheck( ValidatorEventArgs e )
    {
        // ...
    }
}";

        public const string ValidationRulesExample = @"<Validation Validator=""@ValidationRule.IsNotEmpty"">
    ...
</Validation>";

        public const string ValidationSummaryExample = @"<Validations Mode=""ValidationMode.Manual"">
    <ValidationSummary Label=""Following error occurs..."" />

    @*other validation fields*@
</Validations>";

    }
}
