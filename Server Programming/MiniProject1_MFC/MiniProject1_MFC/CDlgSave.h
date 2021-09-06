#pragma once


// CDlgSave 대화 상자

class CDlgSave : public CDialogEx
{
	DECLARE_DYNAMIC(CDlgSave)

public:
	CDlgSave(CWnd* pParent = nullptr);   // 표준 생성자입니다.
	virtual ~CDlgSave();
	int state;			// 1 : OK , 2 : No, 3 : Cancel

// 대화 상자 데이터입니다.
#ifdef AFX_DESIGN_TIME
	enum { IDD = IDD_DLG_SAVE };
#endif

protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV 지원입니다.

	DECLARE_MESSAGE_MAP()
public:
	afx_msg void OnBnClickedOk();
	afx_msg void OnClickedBtNo();
	afx_msg void OnBnClickedCancel();
};
