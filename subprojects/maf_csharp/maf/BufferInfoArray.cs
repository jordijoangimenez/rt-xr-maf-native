//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (https://www.swig.org).
// Version 4.1.1
//
// Do not make changes to this file unless you know what you are doing - modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace maf {

public class BufferInfoArray : global::System.IDisposable, global::System.Collections.IEnumerable, global::System.Collections.Generic.IEnumerable<BufferInfo>
 {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal BufferInfoArray(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(BufferInfoArray obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(BufferInfoArray obj) {
    if (obj != null) {
      if (!obj.swigCMemOwn)
        throw new global::System.ApplicationException("Cannot release ownership as memory is not owned");
      global::System.Runtime.InteropServices.HandleRef ptr = obj.swigCPtr;
      obj.swigCMemOwn = false;
      obj.Dispose();
      return ptr;
    } else {
      return new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
    }
  }

  ~BufferInfoArray() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          mafPINVOKE.delete_BufferInfoArray(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public BufferInfoArray(global::System.Collections.IEnumerable c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (BufferInfo element in c) {
      this.Add(element);
    }
  }

  public BufferInfoArray(global::System.Collections.Generic.IEnumerable<BufferInfo> c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (BufferInfo element in c) {
      this.Add(element);
    }
  }

  public bool IsFixedSize {
    get {
      return false;
    }
  }

  public bool IsReadOnly {
    get {
      return false;
    }
  }

  public BufferInfo this[int index]  {
    get {
      return getitem(index);
    }
    set {
      setitem(index, value);
    }
  }

  public int Capacity {
    get {
      return (int)capacity();
    }
    set {
      if (value < 0 || (uint)value < size())
        throw new global::System.ArgumentOutOfRangeException("Capacity");
      reserve((uint)value);
    }
  }

  public int Count {
    get {
      return (int)size();
    }
  }

  public bool IsSynchronized {
    get {
      return false;
    }
  }

  public void CopyTo(BufferInfo[] array)
  {
    CopyTo(0, array, 0, this.Count);
  }

  public void CopyTo(BufferInfo[] array, int arrayIndex)
  {
    CopyTo(0, array, arrayIndex, this.Count);
  }

  public void CopyTo(int index, BufferInfo[] array, int arrayIndex, int count)
  {
    if (array == null)
      throw new global::System.ArgumentNullException("array");
    if (index < 0)
      throw new global::System.ArgumentOutOfRangeException("index", "Value is less than zero");
    if (arrayIndex < 0)
      throw new global::System.ArgumentOutOfRangeException("arrayIndex", "Value is less than zero");
    if (count < 0)
      throw new global::System.ArgumentOutOfRangeException("count", "Value is less than zero");
    if (array.Rank > 1)
      throw new global::System.ArgumentException("Multi dimensional array.", "array");
    if (index+count > this.Count || arrayIndex+count > array.Length)
      throw new global::System.ArgumentException("Number of elements to copy is too large.");
    for (int i=0; i<count; i++)
      array.SetValue(getitemcopy(index+i), arrayIndex+i);
  }

  public BufferInfo[] ToArray() {
    BufferInfo[] array = new BufferInfo[this.Count];
    this.CopyTo(array);
    return array;
  }

  global::System.Collections.Generic.IEnumerator<BufferInfo> global::System.Collections.Generic.IEnumerable<BufferInfo>.GetEnumerator() {
    return new BufferInfoArrayEnumerator(this);
  }

  global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator() {
    return new BufferInfoArrayEnumerator(this);
  }

  public BufferInfoArrayEnumerator GetEnumerator() {
    return new BufferInfoArrayEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class BufferInfoArrayEnumerator : global::System.Collections.IEnumerator
    , global::System.Collections.Generic.IEnumerator<BufferInfo>
  {
    private BufferInfoArray collectionRef;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public BufferInfoArrayEnumerator(BufferInfoArray collection) {
      collectionRef = collection;
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public BufferInfo Current {
      get {
        if (currentIndex == -1)
          throw new global::System.InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new global::System.InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new global::System.InvalidOperationException("Collection modified.");
        return (BufferInfo)currentObject;
      }
    }

    // Type-unsafe IEnumerator.Current
    object global::System.Collections.IEnumerator.Current {
      get {
        return Current;
      }
    }

    public bool MoveNext() {
      int size = collectionRef.Count;
      bool moveOkay = (currentIndex+1 < size) && (size == currentSize);
      if (moveOkay) {
        currentIndex++;
        currentObject = collectionRef[currentIndex];
      } else {
        currentObject = null;
      }
      return moveOkay;
    }

    public void Reset() {
      currentIndex = -1;
      currentObject = null;
      if (collectionRef.Count != currentSize) {
        throw new global::System.InvalidOperationException("Collection modified.");
      }
    }

    public void Dispose() {
        currentIndex = -1;
        currentObject = null;
    }
  }

  public void Clear() {
    mafPINVOKE.BufferInfoArray_Clear(swigCPtr);
  }

  public void Add(BufferInfo x) {
    mafPINVOKE.BufferInfoArray_Add(swigCPtr, BufferInfo.getCPtr(x));
    if (mafPINVOKE.SWIGPendingException.Pending) throw mafPINVOKE.SWIGPendingException.Retrieve();
  }

  private uint size() {
    uint ret = mafPINVOKE.BufferInfoArray_size(swigCPtr);
    return ret;
  }

  private uint capacity() {
    uint ret = mafPINVOKE.BufferInfoArray_capacity(swigCPtr);
    return ret;
  }

  private void reserve(uint n) {
    mafPINVOKE.BufferInfoArray_reserve(swigCPtr, n);
  }

  public BufferInfoArray() : this(mafPINVOKE.new_BufferInfoArray__SWIG_0(), true) {
  }

  public BufferInfoArray(BufferInfoArray other) : this(mafPINVOKE.new_BufferInfoArray__SWIG_1(BufferInfoArray.getCPtr(other)), true) {
    if (mafPINVOKE.SWIGPendingException.Pending) throw mafPINVOKE.SWIGPendingException.Retrieve();
  }

  public BufferInfoArray(int capacity) : this(mafPINVOKE.new_BufferInfoArray__SWIG_2(capacity), true) {
    if (mafPINVOKE.SWIGPendingException.Pending) throw mafPINVOKE.SWIGPendingException.Retrieve();
  }

  private BufferInfo getitemcopy(int index) {
    BufferInfo ret = new BufferInfo(mafPINVOKE.BufferInfoArray_getitemcopy(swigCPtr, index), true);
    if (mafPINVOKE.SWIGPendingException.Pending) throw mafPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private BufferInfo getitem(int index) {
    BufferInfo ret = new BufferInfo(mafPINVOKE.BufferInfoArray_getitem(swigCPtr, index), false);
    if (mafPINVOKE.SWIGPendingException.Pending) throw mafPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void setitem(int index, BufferInfo val) {
    mafPINVOKE.BufferInfoArray_setitem(swigCPtr, index, BufferInfo.getCPtr(val));
    if (mafPINVOKE.SWIGPendingException.Pending) throw mafPINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddRange(BufferInfoArray values) {
    mafPINVOKE.BufferInfoArray_AddRange(swigCPtr, BufferInfoArray.getCPtr(values));
    if (mafPINVOKE.SWIGPendingException.Pending) throw mafPINVOKE.SWIGPendingException.Retrieve();
  }

  public BufferInfoArray GetRange(int index, int count) {
    global::System.IntPtr cPtr = mafPINVOKE.BufferInfoArray_GetRange(swigCPtr, index, count);
    BufferInfoArray ret = (cPtr == global::System.IntPtr.Zero) ? null : new BufferInfoArray(cPtr, true);
    if (mafPINVOKE.SWIGPendingException.Pending) throw mafPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Insert(int index, BufferInfo x) {
    mafPINVOKE.BufferInfoArray_Insert(swigCPtr, index, BufferInfo.getCPtr(x));
    if (mafPINVOKE.SWIGPendingException.Pending) throw mafPINVOKE.SWIGPendingException.Retrieve();
  }

  public void InsertRange(int index, BufferInfoArray values) {
    mafPINVOKE.BufferInfoArray_InsertRange(swigCPtr, index, BufferInfoArray.getCPtr(values));
    if (mafPINVOKE.SWIGPendingException.Pending) throw mafPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveAt(int index) {
    mafPINVOKE.BufferInfoArray_RemoveAt(swigCPtr, index);
    if (mafPINVOKE.SWIGPendingException.Pending) throw mafPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveRange(int index, int count) {
    mafPINVOKE.BufferInfoArray_RemoveRange(swigCPtr, index, count);
    if (mafPINVOKE.SWIGPendingException.Pending) throw mafPINVOKE.SWIGPendingException.Retrieve();
  }

  public static BufferInfoArray Repeat(BufferInfo value, int count) {
    global::System.IntPtr cPtr = mafPINVOKE.BufferInfoArray_Repeat(BufferInfo.getCPtr(value), count);
    BufferInfoArray ret = (cPtr == global::System.IntPtr.Zero) ? null : new BufferInfoArray(cPtr, true);
    if (mafPINVOKE.SWIGPendingException.Pending) throw mafPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Reverse() {
    mafPINVOKE.BufferInfoArray_Reverse__SWIG_0(swigCPtr);
  }

  public void Reverse(int index, int count) {
    mafPINVOKE.BufferInfoArray_Reverse__SWIG_1(swigCPtr, index, count);
    if (mafPINVOKE.SWIGPendingException.Pending) throw mafPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetRange(int index, BufferInfoArray values) {
    mafPINVOKE.BufferInfoArray_SetRange(swigCPtr, index, BufferInfoArray.getCPtr(values));
    if (mafPINVOKE.SWIGPendingException.Pending) throw mafPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
