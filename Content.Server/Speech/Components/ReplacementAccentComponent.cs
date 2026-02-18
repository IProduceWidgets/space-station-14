using Content.Server.Speech.Prototypes;
using Robust.Shared.Serialization.TypeSerializers.Implementations.Custom.Prototype;

namespace Content.Server.Speech.Components;

/// <summary>
/// Replaces full sentences or words within sentences with new strings.
/// </summary>
[RegisterComponent]
public sealed partial class ReplacementAccentComponent : Component
{
    [DataField(customTypeSerializer: typeof(PrototypeIdSerializer<ReplacementAccentPrototype>), required: true)]
    public string Accent = default!;

    /// <summary>
    /// The last message the speaker sent.
    /// Used to allow the user to override the accent by saying the same message twice in a row.
    /// </summary>
    [DataField]
    public string? LastMessage;
}
