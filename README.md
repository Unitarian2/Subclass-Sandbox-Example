# Subclass-Sandbox-Example
Subclass Sandbox Pattern ile Spawnable ve Interactable Prefab'ların yaşam sürecini kontrol eden bir yapıyı içeren basit bir FPS oyunu prototipi reposudur.<br>


HealCircle,DamageCircle ve ManaCircle'ların bir yaşam süreci eklenmiştir. Ancak her Circle yaşam sürecine ait bazı ortak methodları kendilerine ait bir yöntemle tanımlayabilir. 

Bu repo, daha önce geliştirilmiş olan FPS prototipinin 4.Versiyonudur(v4). Bu Readme'de sadece v4'te değiştirilen veya eklenen kısımlar açıklanacaktır.<br>
Diğer sınıfların açıklamaları için :<br>
v3 => https://github.com/Unitarian2/PickupableItemFactoryWithFlyweightPattern<br>
v2 => https://github.com/Unitarian2/BasicAdapterExample<br>
v1 => https://github.com/Unitarian2/ObserverPattern-MVP-Based-User-Interface<br><br>


<b>CircleLifeCycle.cs</b> => Magic Circle'ların davranışlarını içeren base class. Bu class bazı ortak metodlar içerirken, her subclass'ın kendi versiyonunu implemente etmesini gerektiren abstract metodlar da içermektedir. Burada hedef, her magic circle'ın Shrink, SpawnUp ve Despawn metodlarını kendi versiyonlarında ve farklı şekilde kullanarak kendi tiplerine özgü bir yaşam süreci geçirmeleridir. <br>
<b>DamageCircleLifeCycle.cs</b> => DamageCircle'ın yaşam sürecinin logic'i buradadır. Activate metodu çağırıldığında yaşam süreci başlar.<br>
<b>HealCircleLifeCycle.cs</b> => HealCircle'ın yaşam sürecinin logic'i buradadır. Activate metodu çağırıldığında yaşam süreci başlar.<br>
<b>ManaCircleLifeCycle.cs</b> => ManaCircle'ın yaşam sürecinin logic'i buradadır. Activate metodu çağırıldığında yaşam süreci başlar.<br><br>

<b>CircleSpawnManager.cs</b> => 10 saniyede bir rastgele bir Magic Circle Spawn eder. Spawn işlemini MagicCircleFactory class'ını kullanarak yapar. StartLifeCycle metodu ile spawn edilen MagicCircle'ın yaşam süreci başlatılır.<br>
<b>MagicCircleFactory.cs</b> => ICircle tipinde bir MagicCircle Spawn eder ve döndürür.<br><br>

<b>ICircle.cs</b> => Bu interface'de StartLifeCycle isminde bir metod tanımlanmıştır. Bu sayede her bir MagicCircle class'ı(DamageCircle.cs, ManaCircle.cs vb.) kendi CircleLifeCycle sınıflarını yaratarak, Activate metodunu çalıştırırlar ve yaşam süreçleri başlamış olur.<br><br>

<b>ObjectPuppetMaster.cs</b> => Bu Singleton class, herhangi bir GameObject için animasyon çalıştıran basit bir classtır.

