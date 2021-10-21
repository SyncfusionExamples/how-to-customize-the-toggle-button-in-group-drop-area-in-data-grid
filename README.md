# How to customize the Toggle button color in GroupDropArea in DataGrid(SfDataGrid)?

## About the sample

This example illustrates how to customize the Toggle button in `GroupDropArea` in [WPF DataGrid](https://www.syncfusion.com/wpf-ui-controls/datagrid) (SfDataGrid).

You can change the Toggle button color by customizing the `ToggleButton` and `GroupDropArea` style in [WPF DataGrid](https://www.syncfusion.com/wpf-ui-controls/datagrid) (SfDataGrid).

```xml
<Window.Resources>
    <Style x:Key="ToggleButtonStyle" TargetType="ToggleButton">
        <Setter Property="Background" Value="Transparent" />
        <Setter Property="Template">
            <Setter.Value>
                <ControlTemplate TargetType="ToggleButton">
                    <Grid Background="{TemplateBinding Background}">
                        <Path Data="M31.460022,0 C34.221447,-4.8935362E-08 36.460022,2.2385764 36.460022,5 C36.460022,7.7614241 34.221447,10 31.460022,10 C28.698599,10 26.460022,7.7614241 26.460022,5 C26.460022,2.2385764 28.698599,-4.8935362E-08 31.460022,0 z M18.208984,0 C20.970407,-4.8935362E-08 23.208984,2.2385764 23.208984,5 C23.208984,7.7614241 20.970407,10 18.208984,10 C15.44756,10 13.208984,7.7614241 13.208984,5 C13.208984,2.2385764 15.44756,-4.8935362E-08 18.208984,0 z M5,0 C7.7614241,-4.8935362E-08 10,2.2385764 10,5 C10,7.7614241 7.7614241,10 5,10 C2.2385764,10 0,7.7614241 0,5 C0,2.2385764 2.2385764,-4.8935362E-08 5,0 z"
                    Fill="Red"
                    SnapsToDevicePixels="True"
                    Stretch="Uniform"
                    UseLayoutRounding="False" />
                    </Grid>
                </ControlTemplate>
            </Setter.Value>
        </Setter>
    </Style>
    <Style TargetType="syncfusion:GroupDropArea">
        <Setter Property="Background" Value="White" />
        <Setter Property="Foreground" Value="Gray" />
        <Setter Property="BorderBrush" Value="Gray" />
        <Setter Property="BorderThickness" Value="1,1,1,0" />
        <Setter Property="Focusable" Value="False" />
        <Setter Property="IsTabStop" Value="False" />
        <Setter Property="Template">
            <Setter.Value>
                <ControlTemplate TargetType="syncfusion:GroupDropArea">
                    <Border BorderBrush="{TemplateBinding BorderBrush}"
                BorderThickness="{TemplateBinding BorderThickness}"
                SnapsToDevicePixels="True">
                        <VisualStateManager.VisualStateGroups>
                            <VisualStateGroup x:Name="ExpansionStates">
                                <VisualStateGroup.Transitions>
                                    <VisualTransition GeneratedDuration="0" />
                                </VisualStateGroup.Transitions>
                                <VisualState x:Name="Collapsed">
                                    <Storyboard>
                                        <ObjectAnimationUsingKeyFrames Storyboard.TargetName="PART_GroupDropAreaBorder" Storyboard.TargetProperty="(FrameworkElement.Margin)">
                                            <DiscreteObjectKeyFrame KeyTime="0:0:0">
                                                <DiscreteObjectKeyFrame.Value>
                                                    <Thickness>0,0,0,0</Thickness>
                                                </DiscreteObjectKeyFrame.Value>
                                            </DiscreteObjectKeyFrame>
                                        </ObjectAnimationUsingKeyFrames>
                                        <DoubleAnimationUsingKeyFrames Storyboard.TargetName="PART_GroupDropAreaBorder" Storyboard.TargetProperty="(FrameworkElement.Height)">
                                            <EasingDoubleKeyFrame KeyTime="0:0:0.2" Value="0">
                                                <EasingDoubleKeyFrame.EasingFunction>
                                                    <CircleEase />
                                                </EasingDoubleKeyFrame.EasingFunction>
                                            </EasingDoubleKeyFrame>
                                        </DoubleAnimationUsingKeyFrames>
                                    </Storyboard>
                                </VisualState>
                                <VisualState x:Name="Expanded">
                                    <Storyboard>
                                        <ObjectAnimationUsingKeyFrames Storyboard.TargetName="PART_GroupDropAreaBorder" Storyboard.TargetProperty="(FrameworkElement.Margin)">
                                            <DiscreteObjectKeyFrame KeyTime="0:0:0">
                                                <DiscreteObjectKeyFrame.Value>
                                                    <Thickness>0,0,0,20</Thickness>
                                                </DiscreteObjectKeyFrame.Value>
                                            </DiscreteObjectKeyFrame>
                                        </ObjectAnimationUsingKeyFrames>
                                        <DoubleAnimationUsingKeyFrames Storyboard.TargetName="PART_GroupDropAreaBorder" Storyboard.TargetProperty="(FrameworkElement.Height)">
                                            <EasingDoubleKeyFrame KeyTime="0:0:0.2" Value="28">
                                                <EasingDoubleKeyFrame.EasingFunction>
                                                    <CircleEase />
                                                </EasingDoubleKeyFrame.EasingFunction>
                                            </EasingDoubleKeyFrame>
                                        </DoubleAnimationUsingKeyFrames>
                                    </Storyboard>
                                </VisualState>
                            </VisualStateGroup>
                        </VisualStateManager.VisualStateGroups>
                        <Grid Background="{TemplateBinding Background}">
                            <Grid.RowDefinitions>
                                <RowDefinition x:Name="rd0" Height="Auto" />
                                <RowDefinition x:Name="rd1" Height="*" />
                            </Grid.RowDefinitions>
                            <Grid.ColumnDefinitions>
                                <ColumnDefinition x:Name="cd0" Width="*" />
                                <ColumnDefinition x:Name="cd1" Width="Auto" />
                            </Grid.ColumnDefinitions>
                            <ToggleButton Grid.Row="0"
                                Grid.Column="1"
                                Width="45"
                                Height="12"
                                Margin="2"
                                Background="Transparent"
                                IsChecked="{Binding Path=IsExpanded,
                                                    RelativeSource={RelativeSource TemplatedParent},
                                                    Mode=TwoWay}"
                                IsTabStop="False"
                                IsThreeState="False"
                                SnapsToDevicePixels="True"
                                Style="{StaticResource ToggleButtonStyle}" />
                            <Border Name="PART_GroupDropAreaBorder"
                        Grid.Row="1"
                        Grid.Column="0"
                        Grid.ColumnSpan="1"
                        Height="0"
                        SnapsToDevicePixels="True">
                                <Grid x:Name="PART_GroupDropAreaGrid"
                            MaxHeight="30"
                            Margin="40,0,0,0">
                                    <Grid HorizontalAlignment="Center"
                                VerticalAlignment="Stretch"
                                Opacity="0.5"
                                Visibility="{TemplateBinding WatermarkTextVisibility}">
                                        <Rectangle RadiusX="5"
                                        RadiusY="5"
                                        SnapsToDevicePixels="True"
                                        Stroke="{TemplateBinding Foreground}"
                                        StrokeDashArray="5,5"
                                        StrokeThickness="1" />
                                        <TextBlock Margin="40,5"
                                        HorizontalAlignment="Center"
                                        VerticalAlignment="Center"
                                        FontSize="14"
                                        Foreground="{TemplateBinding Foreground}"
                                        Text="{TemplateBinding GroupDropAreaText}" />
                                    </Grid>
                                    <StackPanel Name="PART_StackPanel"
                                    MaxHeight="30"
                                    Orientation="Horizontal" />
                                </Grid>
                            </Border>
                        </Grid>
                    </Border>
                </ControlTemplate>
            </Setter.Value>
        </Setter>
    </Style>
</Window.Resources>
```

KB article - [How to customize the Toggle button color in GroupDropArea in DataGrid(SfDataGrid)?](https://www.syncfusion.com/kb/11231/how-to-customize-the-toggle-button-color-in-groupdroparea-in-wpf-datagrid-sfdatagrid)

## Requirements to run the demo
Visual Studio 2015 and above versions
