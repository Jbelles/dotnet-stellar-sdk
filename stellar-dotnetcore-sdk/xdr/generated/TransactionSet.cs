// Automatically generated by xdrgen
// DO NOT EDIT or your changes may be overwritten
using System;

namespace stellar_dotnetcore_sdk.xdr {

// === xdr source ============================================================

//  struct TransactionSet
//  {
//      Hash previousLedgerHash;
//      TransactionEnvelope txs<>;
//  };

//  ===========================================================================
public class TransactionSet  {
  public TransactionSet () {}
  public Hash PreviousLedgerHash {get; set;}
  public TransactionEnvelope[] Txs {get; set;}

  public static void Encode(IByteWriter stream, TransactionSet encodedTransactionSet) {
    Hash.Encode(stream, encodedTransactionSet.PreviousLedgerHash);
    int txssize = encodedTransactionSet.Txs.Length;
    XdrEncoding.EncodeInt32(txssize, stream);
    for (int i = 0; i < txssize; i++) {
      TransactionEnvelope.Encode(stream, encodedTransactionSet.Txs[i]);
    }
  }
  public static TransactionSet Decode(IByteReader stream) {
    TransactionSet decodedTransactionSet = new TransactionSet();
    decodedTransactionSet.PreviousLedgerHash = Hash.Decode(stream);
    int txssize = XdrEncoding.DecodeInt32(stream);
    decodedTransactionSet.Txs = new TransactionEnvelope[txssize];
    for (int i = 0; i < txssize; i++) {
      decodedTransactionSet.Txs[i] = TransactionEnvelope.Decode(stream);
    }
    return decodedTransactionSet;
  }
}
}