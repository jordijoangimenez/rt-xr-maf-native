
**Source files generated by [SWIG](https://swig.org/) should not be edited directly :**
```
subprojects/maf_csharp/maf.cpp
subprojects/maf_csharp/maf
```

Instead, the `maf.i` file should be edited and the bindings re-generated using SWIG:

1. Make sure to remove previously generated bindings before generating new ones to keep the directory clean:
```
swig.exe -c++ -csharp -namespace maf -dllimport maf_cs -Isubprojects/maf/include -o subprojects/maf_csharp/maf.cpp -outdir subprojects/maf_csharp/maf subprojects/maf_csharp/maf.i
```

2. Build the C++ wrapper, install it along with the C# source, and cs project files:
```
meson setup -Dcsharp=true builddir
meson install -C builddir --destdir /path/to/unity-project/packages/com.maf
```
