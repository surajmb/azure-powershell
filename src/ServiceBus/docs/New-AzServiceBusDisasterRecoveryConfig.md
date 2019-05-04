---
external help file: Az.ServiceBus-help.xml
Module Name: Az.ServiceBus
online version: https://docs.microsoft.com/en-us/powershell/module/az.servicebus/new-azservicebusdisasterrecoveryconfig
schema: 2.0.0
---

# New-AzServiceBusDisasterRecoveryConfig

## SYNOPSIS
Creates or updates a new Alias(Disaster Recovery configuration)

## SYNTAX

### CreateSubscriptionIdViaHost (Default)
```
New-AzServiceBusDisasterRecoveryConfig -AliasName <String> -NamespaceName <String> -ResourceGroupName <String>
 [-Parameter <IArmDisasterRecovery>] [-PassThru] [-DefaultProfile <PSObject>] [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

### CreateExpanded
```
New-AzServiceBusDisasterRecoveryConfig -AliasName <String> -NamespaceName <String> -ResourceGroupName <String>
 -SubscriptionId <String> [-PassThru] [-AlternateName <String>] [-PartnerNamespace <String>]
 [-DefaultProfile <PSObject>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### Create
```
New-AzServiceBusDisasterRecoveryConfig -AliasName <String> -NamespaceName <String> -ResourceGroupName <String>
 -SubscriptionId <String> [-Parameter <IArmDisasterRecovery>] [-PassThru] [-DefaultProfile <PSObject>]
 [-WhatIf] [-Confirm] [<CommonParameters>]
```

### CreateSubscriptionIdViaHostExpanded
```
New-AzServiceBusDisasterRecoveryConfig -AliasName <String> -NamespaceName <String> -ResourceGroupName <String>
 [-PassThru] [-AlternateName <String>] [-PartnerNamespace <String>] [-DefaultProfile <PSObject>] [-WhatIf]
 [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Creates or updates a new Alias(Disaster Recovery configuration)

## EXAMPLES

### Example 1
```powershell
PS C:\> {{ Add example code here }}
```

{{ Add example description here }}

## PARAMETERS

### -AliasName
The Disaster Recovery configuration name

```yaml
Type: System.String
Parameter Sets: (All)
Aliases: Alias

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AlternateName
Primary/Secondary eventhub namespace name, which is part of GEO DR pairing

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateSubscriptionIdViaHostExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DefaultProfile
The credentials, account, tenant, and subscription used for communication with Azure.

```yaml
Type: System.Management.Automation.PSObject
Parameter Sets: (All)
Aliases: AzureRMContext, AzureCredential

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NamespaceName
The namespace name

```yaml
Type: System.String
Parameter Sets: (All)
Aliases: Namespace

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Parameter
Single item in List or Get Alias(Disaster Recovery configuration) operation

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20170401.IArmDisasterRecovery
Parameter Sets: CreateSubscriptionIdViaHost, Create
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -PartnerNamespace
ARM Id of the Primary/Secondary eventhub namespace name, which is part of GEO DR pairing

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateSubscriptionIdViaHostExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PassThru
When specified, PassThru will force the cmdlet return a 'bool' given that there isn't a return type by default.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResourceGroupName
Name of the Resource group within the Azure subscription.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SubscriptionId
Subscription credentials that uniquely identify a Microsoft Azure subscription.
The subscription ID forms part of the URI for every service call.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Confirm
Prompts you for confirmation before running the cmdlet.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: cf

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WhatIf
Shows what would happen if the cmdlet runs.
The cmdlet is not run.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: wi

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

### Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20170401.IArmDisasterRecovery
## NOTES

## RELATED LINKS

[https://docs.microsoft.com/en-us/powershell/module/az.servicebus/new-azservicebusdisasterrecoveryconfig](https://docs.microsoft.com/en-us/powershell/module/az.servicebus/new-azservicebusdisasterrecoveryconfig)
