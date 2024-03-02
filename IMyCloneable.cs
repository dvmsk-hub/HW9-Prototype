namespace HW9_Prototype_pattern;

/// <summary>
/// Кастомный интерфейс для реализации шаблона "Прототип".
/// </summary>
/// <typeparam name="T"></typeparam>
public interface IMyCloneable<T>
{
    T Copy();
}